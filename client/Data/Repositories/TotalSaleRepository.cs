using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace client.Data
{
    public class TotalSaleRepository
    {
        AppDbContext _db;
        public TotalSaleRepository()
        {
            _db = new AppDbContext();
        }

        public IEnumerable<TotalSale> GetAll()
        {
            return _db.TotalSales;
        }

        public IEnumerable<TotalSale> GetByDate(DateTime date)
        {
            CalculateTotalSale(date);
            return _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date));
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        public bool Add(TotalSale totalSale)
        {
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.TotalSales.Add(totalSale);
            _db.SaveChanges();
            return true;
        }

        public TotalSale Find(int id)
        {
            return _db.TotalSales.Find(id);
        }

        public bool Update(TotalSale totalSale)
        {
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.TotalSales.Update(totalSale);
            _db.SaveChanges();
            return true;
        }

        public bool Remove(TotalSale totalSale)
        {
            _db.TotalSales.Remove(totalSale);
            return true;
        }

        private void CalculateTotalSale(DateTime date)
        {
            if(isNotAvailable(date) || date.Date.Equals(DateTime.Now.Date))
            {
                
                TransactionRepository transactionRepository = new TransactionRepository();
                BorrowRepository borrowRepository = new BorrowRepository();
                SaleReturnRepository saleReturnRepository = new SaleReturnRepository();

                IEnumerable<Transaction> transactions = transactionRepository.GetAllByDate(date);
                IEnumerable<Borrow> borrows = borrowRepository.GetAllByDate(date);
                IEnumerable<SaleReturn> saleReturns = saleReturnRepository.GetAllByDate(date);

                double CashPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Cash).Sum(row => row.Amount);
                double CardPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Card).Sum(row => row.Amount);
                double UPIPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.UPI).Sum(row => row.Amount);
                double ExtraAmount = (double)transactions.Sum(row => row.Extras);
                double SaleReturnAmount = (double)saleReturns.Sum(row => row.Amount);
                double BorrowAmount = (double)borrows.Sum(row => row.Amount);
                double TotalSaleAmount = CashPayment + CardPayment + UPIPayment + SaleReturnAmount + BorrowAmount - ExtraAmount;

                TotalSale totalSale = new TotalSale
                {
                    CashAmount = (decimal)CashPayment,
                    CardAmount = (decimal)CardPayment,
                    UPIAmount = (decimal)UPIPayment,
                    SaleReturnAmount = (decimal)SaleReturnAmount,
                    ExtraAmount = (decimal)ExtraAmount,
                    TotalSaleAmount = (decimal)TotalSaleAmount,
                    Date = DateTime.Now
                };
                Update(totalSale);
                
            }
        }

        private bool isNotAvailable(DateTime date) 
        {
            return !_db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).Any();
        }


        /*
        public TotalSale GetCurrentTotalSale() 
        {
            //_db.TotalSales.Where(row => row.Date.Date.Equals())
            //CalculateTotalSale();
            IEnumerable<TotalSale> totalSales = GetByDate(DateTime.Now);
            if(totalSales != null)
            {
                if (totalSales.Any())
                {
                    return totalSales.First();
                }
            }
            return null;
        }
        */
    }
}

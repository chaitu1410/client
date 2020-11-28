using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _db.TotalSales.OrderBy(row => row.Date);
        }

        public IEnumerable<TotalSale> GetByDate(DateTime date)
        {
            CreateTotalSale(date);
            return _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date));
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        private TotalSale FindByDate(DateTime date)
        {
            return _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).FirstOrDefault();
        }

        private bool Add(TotalSale totalSale)
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

        private bool Update(TotalSale totalSale)
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

        private async Task<TotalSale> CalculateTotalSale(DateTime date)
        {       
            TransactionRepository transactionRepository = new TransactionRepository();
            BorrowRepository borrowRepository = new BorrowRepository();
            SaleReturnRepository saleReturnRepository = new SaleReturnRepository();

            IEnumerable<Transaction> transactions = await transactionRepository.GetAllByDate(date);
            IEnumerable<Borrow> borrowsUndeposited = borrowRepository.GetAllUndepositedByDate(date);
            IEnumerable<Borrow> borrowsDeposited = borrowRepository.GetAllDepositedByDate(date);
            IEnumerable<SaleReturn> saleReturns = saleReturnRepository.GetAllByDate(date);

            double CashPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Cash).Sum(row => row.Amount);
            double CardPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Card).Sum(row => row.Amount);
            double UPIPayment = (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.UPI).Sum(row => row.Amount);
            double ExtraAmount = (double)transactions.Sum(row => row.Extras);
            double SaleReturnAmount = (double)saleReturns.Sum(row => row.Amount);
            double BorrowingBalanceAmount = (double)borrowsUndeposited.Sum(row => row.Amount);
            double CreditDepositAmount = (double)borrowsDeposited.Sum(row => row.Amount);

            double TotalSaleAmount = CashPayment + CardPayment + UPIPayment + SaleReturnAmount + (BorrowingBalanceAmount + CreditDepositAmount) - ExtraAmount;

            TotalSale totalSale = new TotalSale
            {
                CashAmount = (decimal)CashPayment,
                CardAmount = (decimal)CardPayment,
                OnlineAmount = (decimal)UPIPayment,
                SaleReturnAmount = (decimal)SaleReturnAmount,
                ExtraAmount = (decimal)ExtraAmount,
                BorrowingBalanceAmount = (decimal)BorrowingBalanceAmount,
                CreditDepositAmount = (decimal)CreditDepositAmount,
                TotalSaleAmount = (decimal)TotalSaleAmount,
                Date = date
            };
            return totalSale;       
        }


        private async void CreateTotalSale(DateTime date)
        {
            if (isNotAvailable(date))
            {
                TotalSale totalSale = await CalculateTotalSale(date);
                Add(totalSale);
            }
            else if (date.Date.Equals(DateTime.Today))
            {
                TotalSale calculatedTotalSale = await CalculateTotalSale(date);
                TotalSale totalSale = FindByDate(date);
                totalSale.CashAmount = calculatedTotalSale.CashAmount;
                totalSale.CardAmount = calculatedTotalSale.CardAmount;
                totalSale.OnlineAmount = calculatedTotalSale.OnlineAmount;
                totalSale.SaleReturnAmount = calculatedTotalSale.SaleReturnAmount;
                totalSale.ExtraAmount = calculatedTotalSale.ExtraAmount;
                totalSale.BorrowingBalanceAmount = calculatedTotalSale.BorrowingBalanceAmount;
                totalSale.CreditDepositAmount = calculatedTotalSale.CreditDepositAmount;
                totalSale.TotalSaleAmount = calculatedTotalSale.TotalSaleAmount;
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

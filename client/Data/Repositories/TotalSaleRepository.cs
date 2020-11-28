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

        public async Task<IEnumerable<TotalSale>> GetAll()
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => _db.TotalSales.OrderByDescending(row => row.Date).ToList());
        }

        public async Task<IEnumerable<TotalSale>> GetByDate(DateTime date)
        {
            AppDbContext _db = new AppDbContext();
            await CreateTotalSale(date);
            return await Task.Run(() => _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).ToList());
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        private async Task<TotalSale> FindByDate(DateTime date)
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).FirstOrDefault());
        }

        private async Task Add(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);
            if (!isValid)
            {
                return;
            }
            _db.TotalSales.Add(totalSale);
            await _db.SaveChangesAsync();
        }

        public async Task<TotalSale> Find(int id)
        {
            AppDbContext _db = new AppDbContext();
            return await _db.TotalSales.FindAsync(id);
        }

        private async Task Update(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);

            if (!isValid)
            {
                return;
            }
            _db.TotalSales.Update(totalSale);
            await _db.SaveChangesAsync();
        }

        public async Task Remove(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            _db.TotalSales.Remove(totalSale);
            await _db.SaveChangesAsync();
        }

        private async Task<TotalSale> CalculateTotalSale(DateTime date)
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            BorrowRepository borrowRepository = new BorrowRepository();
            SaleReturnRepository saleReturnRepository = new SaleReturnRepository();

            IEnumerable<Transaction> transactions = await transactionRepository.GetAllByDate(date);
            IEnumerable<Borrow> borrowsUndeposited = await borrowRepository.GetAllUndepositedByDate(date);
            IEnumerable<Borrow> borrowsDeposited = await borrowRepository.GetAllDepositedByDate(date);
            IEnumerable<SaleReturn> saleReturns = saleReturnRepository.GetAllByDate(date);

            double CashPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Cash).Sum(row => row.Amount));
            double CardPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Card).Sum(row => row.Amount));
            double UPIPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Online).Sum(row => row.Amount));
            double ExtraAmount = await Task.Run(() => (double)transactions.Sum(row => row.Extras));
            double SaleReturnAmount = await Task.Run(() => (double)saleReturns.Sum(row => row.Amount));
            double BorrowingBalanceAmount = await Task.Run(() => (double)borrowsUndeposited.Sum(row => row.Amount));
            double CreditDepositAmount = await Task.Run(() => (double)borrowsDeposited.Sum(row => row.Amount));

            double TotalSaleAmount = await Task.Run(() => (CashPayment + CardPayment + UPIPayment + SaleReturnAmount + BorrowingBalanceAmount - CreditDepositAmount - ExtraAmount));

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


        private async Task CreateTotalSale(DateTime date)
        {
            if (await isNotAvailable(date))
            {
                TotalSale totalSale = await CalculateTotalSale(date);
                await Add(totalSale);
            }
            else if (date.Date.Equals(DateTime.Today))
            {
                TotalSale calculatedTotalSale = await CalculateTotalSale(date);
                TotalSale totalSale = await FindByDate(date);
                totalSale.CashAmount = calculatedTotalSale.CashAmount;
                totalSale.CardAmount = calculatedTotalSale.CardAmount;
                totalSale.OnlineAmount = calculatedTotalSale.OnlineAmount;
                totalSale.SaleReturnAmount = calculatedTotalSale.SaleReturnAmount;
                totalSale.ExtraAmount = calculatedTotalSale.ExtraAmount;
                totalSale.BorrowingBalanceAmount = calculatedTotalSale.BorrowingBalanceAmount;
                totalSale.CreditDepositAmount = calculatedTotalSale.CreditDepositAmount;
                totalSale.TotalSaleAmount = calculatedTotalSale.TotalSaleAmount;
                await Update(totalSale);
            }
        }

        private async Task<bool> isNotAvailable(DateTime date) 
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => !_db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).Any());
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

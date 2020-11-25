using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Data
{
    /*
      * author = Chaitanya Shinde
     */
    class TransactionRepository
    {
        AppDbContext _db;
        public TransactionRepository()
        {
            _db = new AppDbContext();
        }

        public async Task<IEnumerable<Transaction>> GetAll()
        {
            return await Task.Run(() => _db.Transactions);
        }

        public async Task<IEnumerable<Transaction>> GetAllByDate(DateTime date) 
        {
            AppDbContext _db = new AppDbContext();
            return  await Task.Run(() => _db.Transactions.Where(t => t.Date.Date.Equals(date.Date)).ToList());
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        public async Task<bool> Add(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid) 
            {
                return false;
            }
            await _db.Transactions.AddAsync(transaction);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Transaction> Find(int id) 
        {
            return await _db.Transactions.FindAsync(id);
        }

        public async Task<bool> Update(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.Transactions.Update(transaction);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Remove(Transaction transaction) 
        {
            _db.Transactions.Remove(transaction);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}

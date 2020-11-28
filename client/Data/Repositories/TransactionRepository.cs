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
        public async Task<IEnumerable<Transaction>> GetAll()
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => _db.Transactions);
        }

        public async Task<IEnumerable<Transaction>> GetAllByDate(DateTime date) 
        {
            AppDbContext _db = new AppDbContext();
            return  await Task.Run(() => _db.Transactions.Where(t => t.Date.Date.Equals(date.Date)).ToList());
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        public async Task Add(Transaction transaction) 
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid) 
            {
                throw new InvaliedValuesException(validationResults.First().ErrorMessage);
            }
             await _db.Transactions.AddAsync(transaction);
             await _db.SaveChangesAsync();
        }

        public async Task<Transaction> Find(int id) 
        {
            AppDbContext _db = new AppDbContext();
            return await _db.Transactions.FindAsync(id);
        }

        public async Task Update(Transaction transaction) 
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid)
            {
                throw new InvaliedValuesException(validationResults.First().ErrorMessage);
            }
            _db.Transactions.Update(transaction);
            await _db.SaveChangesAsync();
        }

        public async Task Remove(Transaction transaction) 
        {
            AppDbContext _db = new AppDbContext();
            _db.Transactions.Remove(transaction);
            await _db.SaveChangesAsync();
        }
    }
}

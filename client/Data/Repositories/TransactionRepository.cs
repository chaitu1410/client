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
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Transactions);
            }
            catch (Exception)
            {
                throw new Exception("Failed to load Daily Transaction Records.");
            }
        }

        public async Task<IEnumerable<Transaction>> GetAllByDate(DateTime date) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Transactions.Where(t => t.Date.Date.Equals(date.Date)).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to load Daily Transaction Records filtered by date.");
            }
        }

        public async Task Add(Transaction transaction) 
        {
            try
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
            catch (InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception("Failed to Add Daily Transaction Record.");
            }
        }

        public async Task<Transaction> Find(int id) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await _db.Transactions.FindAsync(id);
            }
            catch (Exception)
            {
                throw new Exception("Failed to Find Daily Transaction Record.");
            }
        }

        public async Task Update(Transaction transaction) 
        {
            try
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
            catch(InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception("Failed to Update Daily Transaction Record.");
            }
        }

        public async Task Remove(Transaction transaction) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                _db.Transactions.Remove(transaction);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Failed to Remove Daily Transaction Record.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

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

        public IEnumerable<Transaction> GetAll() 
        {
            return _db.Transactions;
        }

        public IEnumerable<Transaction> GetAllByDate(DateTime date) 
        {
            return _db.Transactions.Where(t => t.Date.Date.Equals(date.Date));
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        public bool Add(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid) 
            {
                return false;
            }
            _db.Transactions.Add(transaction);
            _db.SaveChanges();
            return true;
        }

        public Transaction Find(int id) 
        {
            return _db.Transactions.Find(id);
        }

        public bool Update(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.Transactions.Update(transaction);
            _db.SaveChanges();
            return true;
        }

        public bool Remove(Transaction transaction) 
        {
            _db.Transactions.Remove(transaction);
            _db.SaveChanges();
            return true;
        }
    }
}

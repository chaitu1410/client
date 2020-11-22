using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string Add(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid) 
            {
                if (validationResults.Count > 0) 
                {
                    return validationResults[0].ErrorMessage;
                }
                else
                {
                    return "Please Enter Valid Information.";
                }
            }
            _db.Transactions.Add(transaction);
            _db.SaveChanges();
            return "Record Inserted Successfully!";
        }

        public Transaction Find(int id) 
        {
            return _db.Transactions.Find(id);
        }

        public string Update(Transaction transaction) 
        {
            ValidationContext context = new ValidationContext(transaction, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(transaction, context, validationResults);

            if (!isValid)
            {
                if (validationResults.Count > 0)
                {
                    return validationResults[0].ErrorMessage;
                }
                else
                {
                    return "Please Enter Valid Updated Information.";
                }
            }
            _db.Transactions.Update(transaction);
            _db.SaveChanges();
            return "Record Updated Successfully!";
        }

        public string Remove(Transaction transaction) 
        {
            _db.Transactions.Remove(transaction);
            return "Record Deleted Successfully!";
        }
    }
}

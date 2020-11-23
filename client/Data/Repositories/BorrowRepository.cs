using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace client.Data
{
    class BorrowRepository
    {
        AppDbContext _db;
        public BorrowRepository()
        {
            _db = new AppDbContext();
        }

        public IEnumerable<Borrow> GetAll() 
        {
            return _db.Borrows;
        }

        public IEnumerable<Borrow> GetAllByDate(DateTime date)
        {
            return _db.Borrows.Where(t => t.Date.Date.Equals(date.Date));
        }

        public bool Add(Borrow borrow) 
        {

            ValidationContext context = new ValidationContext(borrow, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(borrow, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.Borrows.Add(borrow);
            _db.SaveChanges();
            return true;
        }

        public bool Update(Borrow borrow) 
        {
            ValidationContext context = new ValidationContext(borrow, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(borrow, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.Borrows.Update(borrow);
            _db.SaveChanges();
            return true;
        }

        public Borrow Find(int id)
        {
            return _db.Borrows.Find(id);
        }

        public bool Remove(Borrow borrow)
        {
            _db.Borrows.Remove(borrow);
            return true;
        }

        public bool MarkReturned(Borrow borrow) 
        {
            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Now;
            _db.Borrows.Update(borrow);
            return true;
        }

    }
}

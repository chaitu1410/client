using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace client.Data
{
    public class BorrowRepository
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

        public IEnumerable<Borrow> GetAllDeposited()
        {
            return _db.Borrows.Where(row => row.IsReturned == true);
        }

        public IEnumerable<Borrow> GetAllUndeposited()
        {
            return _db.Borrows.Where(row => row.IsReturned == false);
        }

        public IEnumerable<Borrow> GetAllByDate(DateTime date)
        {
            return _db.Borrows.Where(t => t.Date.Date.Equals(date.Date));
        }

        public IEnumerable<Borrow> GetAllDepositedByDate(DateTime date)
        {
            return _db.Borrows.Where(row => row.ReturnDate.Date.Equals(date.Date) && row.IsReturned == true);
        }

        public IEnumerable<Borrow> GetAllUndepositedByDate(DateTime date)
        {
            return _db.Borrows.Where(row => row.Date.Date.Equals(date.Date) && row.IsReturned == false);
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
            if (borrow.IsReturned && borrow.ReturnDate.Equals(new DateTime(0001,01,01)))
            {
                borrow.ReturnDate = DateTime.Now;
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
            _db.SaveChanges();
            return true;
        }

        public bool MarkAsDeposited(Borrow borrow) 
        {
            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Now;
            _db.Borrows.Update(borrow);
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace client.Data
{
    public class SaleReturnRepository
    {
        AppDbContext _db;
        public SaleReturnRepository()
        {
            _db = new AppDbContext();
        }

        public IEnumerable<SaleReturn> GetAll()
        {
            return _db.SaleReturns;
        }

        public IEnumerable<SaleReturn> GetAllByDate(DateTime date)
        {
            return _db.SaleReturns.Where(t => t.Date.Date.Equals(date.Date));
        }

        public bool Add(SaleReturn saleReturn)
        {

            ValidationContext context = new ValidationContext(saleReturn, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(saleReturn, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.SaleReturns.Add(saleReturn);
            _db.SaveChanges();
            return true;
        }

        public bool Update(SaleReturn saleReturn)
        {
            ValidationContext context = new ValidationContext(saleReturn, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(saleReturn, context, validationResults);

            if (!isValid)
            {
                return false;
            }
            _db.SaleReturns.Update(saleReturn);
            _db.SaveChanges();
            return true;
        }

        public SaleReturn Find(int id)
        {
            return _db.SaleReturns.Find(id);
        }

        public bool Remove(SaleReturn saleReturn)
        {
            _db.SaleReturns.Remove(saleReturn);
            return true;
        }
    }
}

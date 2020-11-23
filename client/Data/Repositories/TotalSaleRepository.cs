using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace client.Data
{
    class TotalSaleRepository
    {
        AppDbContext _db;
        public TotalSaleRepository()
        {
            _db = new AppDbContext();
        }

        public IEnumerable<TotalSale> GetAll()
        {
            return _db.TotalSales;
        }

        public IEnumerable<TotalSale> GetAllByDate(DateTime date)
        {
            return _db.TotalSales.Where(t => t.Date.Date.Equals(date.Date));
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        public bool Add(TotalSale totalSale)
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

        public bool Update(TotalSale totalSale)
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
    }
}

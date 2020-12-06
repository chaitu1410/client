using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Data
{
    public class SaleReturnRepository
    {

        public async Task<IEnumerable<SaleReturn>> GetAll()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.SaleReturns.ToList());
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to fetch Sale Return Records.");
            }
        }

        public async Task<IEnumerable<SaleReturn>> GetAllByDate(DateTime date)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.SaleReturns.Where(t => t.Date.Date.Equals(date.Date)).ToList());
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to fetch Sale Return Records filtered by Date.");
            }
        }

        public async Task<IEnumerable<SaleReturn>> GetAllByName(string name)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.SaleReturns.Where(t => t.CustomerName.Contains(name)).ToList());
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to fetch Sale Return Records filtered by Date.");
            }
        }

        public async Task<string[]> GetAllName(string name)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.SaleReturns.Where(t => t.CustomerName.Contains(name)).Select(t => t.CustomerName).ToArray());
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to fetch Sale Return Records filtered by Date.");
            }
        }

        public async Task Add(SaleReturn saleReturn)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                ValidationContext context = new ValidationContext(saleReturn, null, null);
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(saleReturn, context, validationResults);

                if (!isValid)
                {
                    throw new InvaliedValuesException(validationResults.First().ErrorMessage);
                }
                await _db.SaleReturns.AddAsync(saleReturn);
                await _db.SaveChangesAsync();
            }
            catch (InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to Save Sale Return Record.");
            }
        }

        public async Task Update(SaleReturn saleReturn)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                ValidationContext context = new ValidationContext(saleReturn, null, null);
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(saleReturn, context, validationResults);

                if (!isValid)
                {
                    throw new InvaliedValuesException(validationResults.First().ErrorMessage);
                }
                await Task.Run(() => _db.SaleReturns.Update(saleReturn));
                await _db.SaveChangesAsync();
            }
            catch (InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to Update Sale Return Record.");
            }
        }

        public async Task<SaleReturn> Find(int id)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await _db.SaleReturns.FindAsync(id);
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to Find Sale Return Record.");
            }
        }

        public async Task Remove(SaleReturn saleReturn)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                await Task.Run(() => _db.SaleReturns.Remove(saleReturn));
            }
            catch (Exception)
            {
                throw new DatabaseException("Failed to Delete Sale Return Record.");
            }
        }
    }
}

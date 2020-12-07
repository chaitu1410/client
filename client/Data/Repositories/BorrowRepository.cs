using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Data
{
    public class BorrowRepository
    {
        /*public async Task<IEnumerable<Borrow>> GetAll() 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Borrow Records.");
            }
        }*/

        public async Task<IEnumerable<Borrow>> GetAllDeposited()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.IsReturned == true).OrderByDescending(row => row.ReturnDate).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Credit Deposit Records.");
            }
        }

        public async Task<IEnumerable<Borrow>> GetAllUndeposited()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.IsReturned == false).OrderByDescending(row => row.Date).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Borrowing Balance Records.");
            }
        }
        /*
        public async Task<IEnumerable<Borrow>> GetAllByDate(DateTime date)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(t => t.Date.Date.Equals(date.Date)).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Borrow Records filtered by date.");
            }
        }
        */
        public async Task<List<Borrow>> GetAllDepositedByDate(DateTime date)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.ReturnDate.Date.Equals(date.Date) && row.IsReturned == true).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Credit Deposit Records filtered by date.");
            }
        }

        public async Task<List<Borrow>> GetAllUndepositedByDate(DateTime date)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.Date.Date.Equals(date.Date) && row.IsReturned == false).ToList());
            }
            catch (Exception)
            {

                throw new Exception("Failed to Get Borrowing Balance Records filtered by date.");
            }
        }

        public async Task<List<Borrow>> GetAllDepositedByName(string name)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.CustomerName.Contains(name) && row.IsReturned == true).ToList());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Credit Deposit Records filtered by date.");
            }
        }

        public async Task<List<Borrow>> GetAllUndepositedByName(string name)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.CustomerName.Contains(name) && row.IsReturned == false).ToList());
            }
            catch (Exception)
            {

                throw new Exception("Failed to Get Borrowing Balance Records filtered by date.");
            }
        }

        public async Task<string[]> GetAllDepositedName()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.IsReturned == true).Select(row => row.CustomerName).ToArray());
            }
            catch (Exception)
            {
                throw new Exception("Failed to Get Credit Deposit Records filtered by date.");
            }
        }

        public async Task<string[]> GetAllUndepositedName()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => _db.Borrows.Where(row => row.IsReturned == false).Select(row => row.CustomerName).ToArray());
            }
            catch (Exception)
            {

                throw new Exception("Failed to Get Borrowing Balance Records filtered by date.");
            }
        }
        public async Task Add(Borrow borrow) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                ValidationContext context = new ValidationContext(borrow, null, null);
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(borrow, context, validationResults);

                if (!isValid)
                {
                    throw new InvaliedValuesException(validationResults.First().ErrorMessage);
                }
                await _db.Borrows.AddAsync(borrow);
                await _db.SaveChangesAsync();
            }
            catch (InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception("Failed to Add Borrow Record.");
            }
        }

        public async Task Update(Borrow borrow) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                ValidationContext context = new ValidationContext(borrow, null, null);
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(borrow, context, validationResults);

                if (!isValid)
                {
                    throw new InvaliedValuesException(validationResults.First().ErrorMessage);
                }
                if (borrow.IsReturned && borrow.ReturnDate.Equals(new DateTime(0001, 01, 01)))
                {
                    borrow.ReturnDate = DateTime.Now;
                }
                await Task.Run(() => _db.Borrows.Update(borrow));
                await _db.SaveChangesAsync();
            }
            catch (InvaliedValuesException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception("Failed to Update Borrow Record.");
            }
        }

        public async Task<Borrow> Find(int id)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await _db.Borrows.FindAsync(id);
            }
            catch (Exception)
            {
                throw new Exception("Failed to Find Borrow Record.");
            }
        }

        public async Task Remove(Borrow borrow)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                await Task.Run(() => _db.Borrows.Remove(borrow));
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Failed to Remove Borrow Record.");
            }
        }
    }
}

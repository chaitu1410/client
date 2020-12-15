using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Data
{
    public class UserRepository
    {
        public async Task<User> GetUser()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return await Task.Run(() => {
                    if(_db.Users.Any())
                        return _db.Users.First();
                    return null;
                });
            }
            catch (Exception)
            {
                throw new Exception("Failed to get User Data.");
            }
        }
        public async Task Update(User user)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                await Task.Run(() => _db.Users.Update(user));
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Failed To Update Credentials.");
            }
        }
    }
}

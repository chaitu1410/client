using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace client.Data
{
    public class UserRepository
    {
        public User GetUser()
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                return _db.Users.First();
            }
            catch (Exception)
            {
                throw new Exception("Failed to get User Data.");
            }
        }
        public void Update(User user)
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                _db.Users.Update(user);
            }
            catch (Exception)
            {
                throw new Exception("Failed To Update Credentials.");
            }
        }
    }
}

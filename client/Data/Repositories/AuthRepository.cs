using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace client.Data
{
    public class AuthRepository
    {
        public static async Task<bool> Authenticate(string email, string password) 
        {
            try
            {
                AppDbContext _db = new AppDbContext();
                User user = await _db.Users.FindAsync(email);
                if (user != null && user.Password == password)
                {
                    return true;
                }
                return false;
            }
            catch (Exception) { 
                throw new Exception("Failed To Authenticate Users."); 
            }
        }
    }
}

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
                UserRepository _userRepository = new UserRepository();
                User user = await _userRepository.GetUser();
                if (user != null && user.Email == email && user.Password == password)
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

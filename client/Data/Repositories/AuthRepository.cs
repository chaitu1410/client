using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    public class AuthRepository
    {
        public bool Authenticate(string email, string password) 
        {
	    AppDbContext _db = new AppDbContext();
            User user = _db.Users.Find(email);
            if(user != null && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    class AuthRepository
    {
        private readonly AppDbContext _db;

        public AuthRepository(AppDbContext db)
        {
            _db = db;
        }
        public bool Authenticate(string email, string password) 
        {
            User user = _db.Users.Find(email);
            if(user != null && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}

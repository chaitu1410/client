using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace client.Data.Repositories
{
    public class UserRepository
    {
        public User GetUser()
        {
            AppDbContext _db = new AppDbContext();
            return _db.Users.First();
        }
        public void Update(User user)
        {
            AppDbContext _db = new AppDbContext();
            _db.Users.Update(user);
        }
    }
}

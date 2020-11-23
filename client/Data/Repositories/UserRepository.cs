using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data.Repositories
{
    class UserRepository
    {
        private readonly AppDbContext _db;

        public UserRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Update(User user)
        {
            _db.Users.Update(user);
        }
    }
}

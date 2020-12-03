using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message)
        {

        }
    }
}

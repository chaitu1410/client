using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    class InvaliedValuesException : Exception
    {
        public InvaliedValuesException(string message) : base(message)
        {
            
        }
    }
}

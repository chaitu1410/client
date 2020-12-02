using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    class PdfGenerationException : Exception
    {
        public PdfGenerationException(string message) : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    public class ApplicationException : Exception
    {
        private string p;

        public ApplicationException() { }

        public ApplicationException(string p)
        {
            this.p = p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class InvalidCreditDataException : Exception
    {
        public InvalidCreditDataException(string errMsg) : base(errMsg) { }
    }
}

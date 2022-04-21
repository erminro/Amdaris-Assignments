using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAndDebugging
{
    public class PayWithCardInsufficientBalanceException:Exception
    {
        public PayWithCardInsufficientBalanceException()
        {
        }

        public PayWithCardInsufficientBalanceException(string message) : base(message)
        {
        }

        public PayWithCardInsufficientBalanceException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected PayWithCardInsufficientBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAndDebugging
{
    public class ExeptionCreateCreditCardAgeLimit:Exception
    {
        public ExeptionCreateCreditCardAgeLimit()
        {
        }

        public ExeptionCreateCreditCardAgeLimit(string message) : base(message)
        {
        }

        public ExeptionCreateCreditCardAgeLimit(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ExeptionCreateCreditCardAgeLimit(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

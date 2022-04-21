using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    internal class Tax9Procent : ITaxStrategy
    {
        public decimal calulatePriceAfterTaxes(decimal price)
        {
            price += price * 9 / 100;
            return price;
        }
    }
}

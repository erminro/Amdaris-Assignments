using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    internal class Tax19Procent : ITaxStrategy
    {
        public decimal calulatePriceAfterTaxes(decimal price)
        {
            price += price * 19 / 100;
            return price;
        }
    }
}

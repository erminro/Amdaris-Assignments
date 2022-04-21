using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    public class TaxContext
    {
            private ITaxStrategy _strategy;

            public void SeStrategy(ITaxStrategy strategy)
            {
                _strategy = strategy;
            }

            public  decimal CalculatePriceAfterTaxes(decimal price)
            {
                if (_strategy == null)  return 0;
                else return _strategy.calulatePriceAfterTaxes(price);
            }

    }
}

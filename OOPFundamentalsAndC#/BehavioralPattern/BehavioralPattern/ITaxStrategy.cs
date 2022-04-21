using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    public interface ITaxStrategy
    {
        public Decimal calulatePriceAfterTaxes(Decimal price);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public interface IProductDecorator
    {
        public string QualityTest(Product product);
    }
}
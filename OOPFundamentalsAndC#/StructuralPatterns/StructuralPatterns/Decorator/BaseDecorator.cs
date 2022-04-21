using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public abstract class BaseDecorator:IProductDecorator
    {
        protected IProductDecorator _productDecorator;
        public BaseDecorator(IProductDecorator productDecorator)
        {
            _productDecorator=productDecorator;
        }

        public abstract string QualityTest(Product product);
    }
}

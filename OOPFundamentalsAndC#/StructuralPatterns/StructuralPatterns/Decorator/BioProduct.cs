using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class BioProduct : BaseDecorator
    {
        public BioProduct(IProductDecorator productDecorator) : base(productDecorator)
        {

        }
        public override string QualityTest(Product product)
        {
            if (product.Category == "Food")
            {
                return _productDecorator.QualityTest(product) + " was tested and it's Bio";
            }
            else
            {
                return _productDecorator.QualityTest(product) + $" is not food and cannot be bio";
            }
        }
    }
}

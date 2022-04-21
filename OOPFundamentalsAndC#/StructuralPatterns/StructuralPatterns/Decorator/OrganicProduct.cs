using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class OrganicProduct : BaseDecorator
    {
        public OrganicProduct(IProductDecorator productDecorator) : base(productDecorator)
        {

        }
        public override string QualityTest(Product product)
        {
            if (product.Category == "Food")
            {
                return _productDecorator.QualityTest(product) + " was tested and it's Organic";
            }
            else
            {
                return _productDecorator.QualityTest(product) + $" is not food and cannot be organic";
            }
        }
    }
}

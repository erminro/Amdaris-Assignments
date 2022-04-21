using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class SimpleProduct : IProductDecorator
    {
        public string QualityTest(Product product)
        {

                return $"Product: {product.Name} with price: {product.Price}";
            
             
        }
    }
}

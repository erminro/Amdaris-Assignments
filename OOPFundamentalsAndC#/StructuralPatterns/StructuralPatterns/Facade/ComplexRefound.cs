using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class ComplexRefound
    {
        public Product _product;
        public ComplexRefound(Product product)
        {
            _product=product;
        }
        public void Init()
        {
            Console.WriteLine("Preparing product for check");
        }
        public void Validation()
        {
            Console.WriteLine("Checking product type");
            if (_product.Category == "Electronics")
            {
                Console.WriteLine($"Product:{_product.Name} is an electronic and it has to be tased and checked for damage");
            }else if(_product.Category == "Chlotes")
            {
                Console.WriteLine($"Product:{_product.Name} is a chloting and it needs to be checked for damage");
            }
            else
            {
                Console.WriteLine($"Product:{_product.Name} is {_product.Category} and cannot be refounded");
            }
        }
        public void TestElectronics()
        {
            if(_product.Category != "Electronics")
            {
                Console.WriteLine($"Product:{_product.Name} is not an electronic and cannot be tested");
            }
            else
            {
                Console.WriteLine("Checking for damage");
                Console.WriteLine($"Performing tests");
                Console.WriteLine($"Issuing refound for product: {_product.Name} in value of {_product.Price}");
            }
        }
        public void CheckChlotes() {
            if (_product.Category != "Chlotes")
            {
                Console.WriteLine($"Product:{_product.Name} is not a chloting product and cannot be checked");
            }
            else
            {
                Console.WriteLine("Checking for damage");
                Console.WriteLine($"Issuing refound for product: {_product.Name} in value of {_product.Price}");
            }
        }
    }
}

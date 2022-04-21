using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class ReturnProductCheckFacade
    {
        public void RefoundProduct(Product product) {
            ComplexRefound complexRefound=new ComplexRefound(product);
            if (product.Category == "Electronics")
            {
                complexRefound.Init();
                complexRefound.Validation();
                complexRefound.TestElectronics();
            }else if(product.Category == "Chlotes")
            {
                complexRefound.Init();
                complexRefound.Validation();
                complexRefound.CheckChlotes();
            }
            else
            {
                Console.WriteLine("This type of product is not eligible for refound");
            }
        }
    }
}

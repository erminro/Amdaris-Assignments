using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public class ThirdPartyProductLibrary:IProductLibrary
    {
        private List<Product> _products;
        public ThirdPartyProductLibrary()
        {
            _products=new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void BuyProduct(Product product)
        {
            
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }
    }
}

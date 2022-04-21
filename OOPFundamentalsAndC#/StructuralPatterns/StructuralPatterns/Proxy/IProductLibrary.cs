using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public interface IProductLibrary
    {
        public void AddProduct(Product product);
        public void RemoveProduct(Product product);
        public List<Product> GetProducts();
        public void BuyProduct(Product product);
    }
}

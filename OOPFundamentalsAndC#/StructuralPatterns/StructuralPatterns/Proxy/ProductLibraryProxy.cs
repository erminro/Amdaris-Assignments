using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public class ProductLibraryProxy:IProductLibrary
    {
        private ThirdPartyProductLibrary _thirdPartyProductLibrary;
        private User _user;
        public ProductLibraryProxy(User user)
        {
            _user=user;
            _thirdPartyProductLibrary = new ThirdPartyProductLibrary();
        }
        public void ChangeUser(User user)
        {
            _user = user;
        }
        public void AddProduct(Product product)
        {
            if (IsAllowed())
            {
                _thirdPartyProductLibrary.AddProduct(product);
            }
            else
            {
                Console.WriteLine($"User:{_user.Name} has no admin privileges cannot add {product.Name}");
            }
        }

        public List<Product> GetProducts()
        {
            return _thirdPartyProductLibrary.GetProducts();
        }

        public void RemoveProduct(Product product)
        {
            if (IsAllowed())
            {
                _thirdPartyProductLibrary.RemoveProduct(product);
            }
            else
            {
                Console.WriteLine($"User:{_user.Name} has no admin privileges cannot delete {product.Name}");
            }
        }
        public bool IsAllowed()
        {
            if (_user.IsAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void BuyProduct(Product product)
        {
            if (IsAllowed())
            {
                Console.WriteLine("Please cange to user from admin to buy products");
            }
            else
            {
                Console.WriteLine($"Issuing payment for {_user.Name} for the product:{product.Name} amount owned:{product.Price}");
            }
        }
    }
}

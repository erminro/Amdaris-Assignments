using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Proxy;
using System;


namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Name="Smart Tv",Price=499.99M,Category="Electronics"};
            Product product2 = new Product() { Name = "Apple", Price = 0.99M, Category = "Food" };
            Product product3 = new Product() { Name = "Shirt", Price = 10.99M, Category = "Chlotes" };
            IProductDecorator productquality = new SimpleProduct();
            productquality = new BioProduct(productquality);
            productquality=new OrganicProduct(productquality);
            Console.WriteLine(productquality.QualityTest(product));
            Console.WriteLine(productquality.QualityTest(product2));
            Console.WriteLine();
            var check = new ReturnProductCheckFacade();
            check.RefoundProduct(product);
            check.RefoundProduct(product2);
            check.RefoundProduct(product3);
            Console.WriteLine();
            User user = new User(){Name="Ermin",IsAdmin=true};
            User user1 = new User() {Name="Alina" ,IsAdmin=false};
            var proxy = new ProductLibraryProxy(user);
            proxy.AddProduct(product);
            proxy.AddProduct(product2);
            proxy.AddProduct(product3);
            var products=proxy.GetProducts();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name);
            }
            proxy.BuyProduct(products[0]);
            Console.WriteLine();
            proxy.RemoveProduct(product3);
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name);
            }
            Console.WriteLine();
            proxy.ChangeUser(user1);
            proxy.AddProduct(product3);
            proxy.RemoveProduct(product);
            var products1=proxy.GetProducts();
            Console.WriteLine();
            for (int i = 0; i < products1.Count; i++)
            {
                Console.WriteLine(products1[i].Name);
            }
            proxy.BuyProduct(products1[0]);

        }
    }
}

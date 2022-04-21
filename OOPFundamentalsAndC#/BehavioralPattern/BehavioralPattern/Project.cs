using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    public class Project
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Select Tax Bracket! 1 -> Tax Bracket 5%; 2 -> Tax Bracket 9%; 3 -> Tax Bracket 19%");
            TaxContext taxContext = new TaxContext();
            var selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {

                taxContext.SeStrategy(new Tax5Procent());
            }
            else if (selection == 2)
            {
                taxContext.SeStrategy(new Tax9Procent());
            }
            else if (selection == 3)
            {
                taxContext.SeStrategy(new Tax9Procent());
            }
            else {
                Console.WriteLine("Not permited");
            }

            Product product = new Product(new Guid(),12.99M,taxContext);
            product.Name = "as";
            product.Description = "as";

            Console.WriteLine(product.ToString());
        }
    }
}

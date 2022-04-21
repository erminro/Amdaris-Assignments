using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InernshipApplication.Web.Domain
{
    public class ProductsCategories
    {
        public Guid Id { get; set; }
        public Guid Categoryid { get; set; }
        public Guid Productid { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}

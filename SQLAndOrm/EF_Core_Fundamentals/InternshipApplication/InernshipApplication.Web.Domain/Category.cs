using System;
using System.Collections.Generic;

namespace InernshipApplication.Web.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public string Name { get; set; }
    }
}

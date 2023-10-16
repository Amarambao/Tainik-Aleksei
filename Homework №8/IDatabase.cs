using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    internal interface IDatabase
    {
        public GenericKeeper<User> Users { get; }
        public GenericKeeper<Product> Products { get; }
        public GenericKeeper<DiscountedProduct> DiscountedProducts { get; }
        public GenericKeeper<Order> Orders { get; }

        public void Save();
    }
}

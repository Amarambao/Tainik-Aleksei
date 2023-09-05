using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    internal interface IDatabase
    {
        public void addUser(User newUser);
        public void addProduct(Product newProduct);
        public void addDiscountedProduct(DiscountedProduct newDiscountedProduct);
        public void addOrder(Order newOrder);
        public List<User> showUsers();
        public List<Product> showProducts();
        public List<DiscountedProduct> showDiscountedProducts();
        public List<Order> showOrders();
    }
}

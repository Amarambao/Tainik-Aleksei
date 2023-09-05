using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    public class InMemoryDatabase : IDatabase
    {
        public static List<User> Users { get; }
        static List<Product> Products;
        static List<DiscountedProduct> DiscountedProducts;
        static List<Order> Orders;
        static InMemoryDatabase()
        {
            Users = new List<User>()
            {
                new User("Ivanov", "Ivan", "Ivanovich", "+375123456789", "Sovietskaya"),
                new User("Borisov", "Boris", "Borisovich", "+375290987654", "Lenina"),
                new User("Petrov", "Peter", "Petrovich", "+375210981256", "Stalina"),
                new User("Vasil'ev", "Vasilyi", "Vasil'evich", "+375251357924", "Molodeznaya")
            };

            Products = new List<Product>()
            {
                new Product("Bread", "Black", 2.55),
                new Product("Milk", "Goat", 4.99),
                new Product("Tea", "Green", 15.49),
                new Product("Cheese", "Belarus", 7.59)
            };

            DiscountedProducts = new List<DiscountedProduct>()
            {
                new DiscountedProduct("Tea", "Discounted green tea", 15.49, 85)
            };

            Orders = new List<Order>() { };

            foreach (var user in Users)
            {
                Order order = new Order(user);
                foreach (var product in Products)
                {
                    order.AddProduct(product);
                }
                Orders.Add(order); 
            }
        }
        public void addUser(User newUser)
        {
            Users.Add(newUser);
        }
        public void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }
        public void addDiscountedProduct(DiscountedProduct newDiscountedProduct)
        {
            DiscountedProducts.Add(newDiscountedProduct);
        }
        public void addOrder(Order order)
        {
            Orders.Add(order);
        }
        public List<User> showUsers()
        {
            List<User> copyUsers = new List<User>(Users);
            return copyUsers;
        }
        public List<Product> showProducts()
        {
            List<Product> copyProducts = new List<Product>(Products);
            return copyProducts;
        }
        public List<DiscountedProduct> showDiscountedProducts()
        {
            List<DiscountedProduct> copyDiscountedProducts = new List<DiscountedProduct>(DiscountedProducts);
            return copyDiscountedProducts;
        }
        public List<Order> showOrders()
        {
            List<Order> copyOrders = new List<Order>(Orders);
            return copyOrders;
        }
    }
}

using Newtonsoft.Json;
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
        public GenericKeeper<User> Users { get; private set; }
        public GenericKeeper<Product> Products { get; private set; }
        public GenericKeeper<DiscountedProduct> DiscountedProducts { get; private set; }
        public GenericKeeper<Order> Orders { get; private set; }
        public InMemoryDatabase()
        {
            Users = new GenericKeeper<User>();

            Users.AddItem(new User("Ivanov", "Ivan", "Ivanovich", "+375123456789", "Sovietskaya"));
            Users.AddItem(new User("Borisov", "Boris", "Borisovich", "+375290987654", "Lenina"));
            Users.AddItem(new User("Petrov", "Peter", "Petrovich", "+375210981256", "Stalina"));
            Users.AddItem(new User("Vasil'ev", "Vasilyi", "Vasil'evich", "+375251357924", "Molodeznaya"));

            Products = new GenericKeeper<Product>();

            Products.AddItem(new Product("Bread", "Black", 2.55));
            Products.AddItem(new Product("Milk", "Goat", 4.99));
            Products.AddItem(new Product("Tea", "Green", 15.49));
            Products.AddItem(new Product("Cheese", "Belarus", 7.59));

            DiscountedProducts = new GenericKeeper<DiscountedProduct>();

            DiscountedProducts.AddItem(new DiscountedProduct("Tea", "Discounted green tea", 15.49, 85));

            Orders = new GenericKeeper<Order>() { };

            foreach (var user in Users.ShowItem())
            {
                Order order = new Order(user);
                foreach (var product in Products.ShowItem())
                {
                    order.AddProduct(product);
                }
                foreach (var discountedProduct in DiscountedProducts.ShowItem())
                {
                    order.AddDiscountedProduct(discountedProduct);
                }
                Orders.AddItem(order); 
            }
        }
        public void Save()
        {
            string srUsers = JsonConvert.SerializeObject(Users.ShowItem());
            using (FileStream fs = new FileStream("Users.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(srUsers);
                }
            }

            string srProducts = JsonConvert.SerializeObject(Products.ShowItem());
            using (FileStream fs = new FileStream("Products.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(srProducts);
                }
            }

            string srOrders = JsonConvert.SerializeObject(Orders.ShowItem());
            using (FileStream fs = new FileStream("Orders.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(srOrders);
                }
            }
        }
    }
}

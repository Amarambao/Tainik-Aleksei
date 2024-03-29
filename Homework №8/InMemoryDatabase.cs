﻿using Newtonsoft.Json;

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
            Products = new GenericKeeper<Product>();
            DiscountedProducts = new GenericKeeper<DiscountedProduct>();
            Orders = new GenericKeeper<Order>();

            LoadUsers();
            LoadProducts();
            LoadDiscountedProducts();
            LoadOrders();

            //Users.AddItem(new User("Ivanov", "Ivan", "Ivanovich", "375123456789", "Sovietskaya"));
            //Users.AddItem(new User("Borisov", "Boris", "Borisovich", "375290987654", "Lenina"));
            //Users.AddItem(new User("Petrov", "Peter", "Petrovich", "375210981256", "Stalina"));
            //Users.AddItem(new User("Vasil'ev", "Vasilyi", "Vasil'evich", "375251357924", "Molodeznaya"));

            //Products.AddItem(new Product("Bread", "Black", 2.55));
            //Products.AddItem(new Product("Milk", "Goat", 4.99));
            //Products.AddItem(new Product("Tea", "Green", 15.49));
            //Products.AddItem(new Product("Cheese", "Belarus", 7.59));

            //DiscountedProducts.AddItem(new DiscountedProduct("Tea", "Discounted green tea", 15.49, 85));

            //foreach (var user in Users.ShowItem())
            //{
            //    Order order = new Order(user);
            //    foreach (var product in Products.ShowItem())
            //    {
            //        order.AddProduct(product);
            //    }
            //    foreach (var discountedProduct in DiscountedProducts.ShowItem())
            //    {
            //        order.AddDiscountedProduct(discountedProduct);
            //    }
            //    Orders.AddItem(order);
            //}
        }
        public void SaveUsers()
        {
            var srUsers = JsonConvert.SerializeObject(Users.ShowItem());

            using FileStream fs = new FileStream("Users.txt", FileMode.Truncate);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(srUsers);
        }
        public void SaveProducts()
        {
            var srProducts = JsonConvert.SerializeObject(Products.ShowItem());

            using FileStream fs = new FileStream("Products.txt", FileMode.Truncate);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(srProducts);
        }
        public void SaveDiscountedProducts()
        {
            var srDiscountedProducts = JsonConvert.SerializeObject(DiscountedProducts.ShowItem());

            using FileStream fs = new FileStream("DiscountedProducts.txt", FileMode.Truncate);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(srDiscountedProducts);
        }
        public void SaveOrders()
        {
            var srOrders = JsonConvert.SerializeObject(Orders.ShowItem());

            using FileStream fs = new FileStream("Orders.txt", FileMode.Truncate);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(srOrders);
        }

        public void LoadUsers()
        {
            using FileStream fs = new FileStream("Users.txt", FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                var users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
                foreach (var user in users)
                {
                    Users.AddItem(user);
                }
            }
        }
        public void LoadProducts()
        {
            using FileStream fs = new FileStream("Products.txt", FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                foreach (var product in products)
                {
                    Products.AddItem(product);
                }
            }
        }
        public void LoadDiscountedProducts()
        {
            using FileStream fs = new FileStream("DiscountedProducts.txt", FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                var discountedProducts = JsonConvert.DeserializeObject<List<DiscountedProduct>>(sr.ReadToEnd());

                foreach (DiscountedProduct discountedProduct in discountedProducts)
                {
                    DiscountedProducts.AddItem(discountedProduct);
                }
            }
        }
        public void LoadOrders()
        {
            using FileStream fs = new FileStream("Orders.txt", FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                var orders = JsonConvert.DeserializeObject<List<Order>>(sr.ReadToEnd());

                foreach (Order order in orders)
                {
                    Orders.AddItem(order);
                }
            }
        }
    }
}

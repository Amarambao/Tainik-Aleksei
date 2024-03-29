﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__7
{
    internal class Order
    {
        const double convertionUSD = 3.09;
        readonly uint orderId;
        readonly User user;
        readonly List<Product> products;

        public uint OrderId
        {
            get => orderId;
        }
        public User User
        {
            get => user;
        }
        public List<Product> Products
        {
            get => products;
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            for (int i = 0; i < products.Count; i++)
            {
                totalPrice += products[i].ProductPrice;
            }
            return totalPrice;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public override string ToString()
        {
            string Products = "";
            foreach(Product prod in products)
            {
                Products += prod.ToString();
                Products += "\n----------\n";
            }
            return $"This order ID = {orderId}\n" +
                $"Total price of this order = {TotalPrice()}\n" +
                $"This order was made by this user --\n{user.ToString()}\n" +
                $"\nThis order have this products --\n{Products}";
        }
        public Order(uint OrderId, User User)
        {
            orderId = OrderId;
            user = User;
            products = new List<Product>();
        }
    }
}

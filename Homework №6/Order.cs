using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__6
{
    internal class Order
    {
        const double convertionUSD = 3.09;
        uint id;
        string surname;
        string name;
        string fatherName;
        string phoneNumber;
        string customerAdress;
        string product;
        string productDescription;
        double productPrice;
        uint productCount;
        public uint Id 
        { 
            get => id; 
        }
        public string Surname 
        { 
            get => surname; 
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    surname = value;
            } 
        }
        public string Name 
        { 
            get => name;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string FatherName 
        { 
            get => fatherName;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    fatherName = value;
            }
        }
        public string PhoneNumber 
        { 
            get => phoneNumber;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    phoneNumber = value;
            }
        }
        public string CustomerAdress 
        { 
            get => customerAdress;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    customerAdress = value;
            }
        }
        public string Product 
        { 
            get =>  product;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    product = value;
            }
        }
        public string ProductDescription 
        { 
            get => productDescription;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    productDescription = value;
            }
        }
        public double ProductPrice 
        { 
            get => productPrice;
            protected set
            {
                if (value > 0)
                    productPrice = value;
            }
        }   
        public uint ProductCount 
        { 
            get => productCount;
            protected set
            {
                if (value != 0)
                    productCount = value;
            }
        }
        public double TotalPrice()
        {
            return (ProductCount * ProductPrice) / convertionUSD;
        }
        public Order (uint id, string Surname, string Name, string FatherName, string Product, string ProductDescription, double ProductPrice, uint ProductCount)
        {
            this.id = id;
            this.Surname = Surname;
            this.Name = Name;
            this.FatherName = FatherName;
            this.Product = Product;
            this.ProductDescription = ProductDescription;
            this.ProductPrice = ProductPrice;
            this.ProductCount = ProductCount;
        }
        public Order (string PhoneNumber, string CustomerAdress) : this(1, "Ivanov", "Ivan", "Ivanovich", "bread", "borodinskyi", 2.55, 3)
        {
            this.PhoneNumber = PhoneNumber;
            this.CustomerAdress = CustomerAdress;
        }
    }
}

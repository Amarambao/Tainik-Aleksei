using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__7
{
    internal class Product
    {
        uint productId;
        string productName;
        string productDescription;
        double productPrice;

        public uint ProductId
        {
            get => productId;
        }
        public string ProductName
        {
            get => productName;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    productName = value;
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
        public virtual double ProductPrice
        {
            get => productPrice;
            protected set
            {
                if (value > 0)
                    productPrice = value;
            }
        }
        public override string ToString()
        {
            return $"Product ID = {ProductId}\n" +
                $"ProductName - {ProductName}\n" +
                $"ProductDescription - {ProductDescription}\n" +
                $"ProductPrice = {ProductPrice}";
        }
        //public override bool Equals(object? prod)
        //{
        //    Product Prod = (Product)prod;
        //    bool equal = this.ProductId == Prod.ProductId 
        //        && this.ProductName == Prod.ProductName 
        //        && this.ProductDescription == Prod.ProductDescription 
        //        && this.ProductPrice == Prod.ProductPrice;
        //    return equal;
        //}
        public override bool Equals(object? prod)
        {
            Product Prod = (Product)prod;
            return this.GetHashCode() == prod.GetHashCode();
        }
        public override int GetHashCode()
        {
            return ProductId.GetHashCode() + ProductName.GetHashCode() + ProductDescription.GetHashCode() + ProductPrice.GetHashCode();
        }
        public Product(uint ProductId, string ProductName, string ProductDescription, double ProductPrice)
        {
            productId = ProductId;
            this.ProductName = ProductName;
            this.ProductDescription = ProductDescription;
            this.ProductPrice = ProductPrice;
        }
    }
}

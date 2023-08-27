using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__7
{
    internal class DiscountedProduct : Product
    {
        public int currentDiscount;
        public int CurrentDuscount
        {
            get => currentDiscount;
            set => currentDiscount = value;
        }
        public override double ProductPrice 
        { 
            get => base.ProductPrice * CurrentDuscount / 100; 
        }
        public DiscountedProduct(uint ProductId, string ProductName, string ProductDescription, double ProductPrice, int CurrentDuscount) 
            : base(ProductId, ProductName, ProductDescription, ProductPrice)
        {
            this.CurrentDuscount = CurrentDuscount;
        }
    }
}

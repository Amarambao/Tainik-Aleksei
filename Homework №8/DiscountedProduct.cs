namespace Homework__8
{
    public class DiscountedProduct : Product
    {
        public int currentDiscount;
        public int CurrentDiscount
        {
            get => currentDiscount;
            set => currentDiscount = value;
        }
        public override double ProductPrice
        {
            get => base.ProductPrice * CurrentDiscount / 100;
        }
        public DiscountedProduct(string ProductName, string ProductDescription, double ProductPrice, int CurrentDuscount)
            : base(ProductName, ProductDescription, ProductPrice)
        {
            this.CurrentDiscount = CurrentDuscount;
        }
    }
}

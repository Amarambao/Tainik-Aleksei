namespace Homework__8
{
    public class Product : BaseModel
    {
        string productName;
        string productDescription;
        double productPrice;

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
            return $"Product ID = {Id.ToString()}\n" +
                $"ProductName - {ProductName}\n" +
                $"ProductDescription - {ProductDescription}\n" +
                $"ProductPrice = {ProductPrice:####,##}";
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
            var Prod = (Product)prod;
            return this.GetHashCode() == prod.GetHashCode();
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() + ProductName.GetHashCode() + ProductDescription.GetHashCode() + ProductPrice.GetHashCode();
        }
        public Product(string ProductName, string ProductDescription, double ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductDescription = ProductDescription;
            this.ProductPrice = ProductPrice;
        }
    }
}

namespace Homework__8
{
    public class Order : BaseModel
    {
        const double CONVERSIONUSD = 3.09;
        readonly User user;
        readonly List<Product> products;

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
        public void AddDiscountedProduct(DiscountedProduct discountedProduct)
        {
            products.Add(discountedProduct);
        }
        public void RemoveDiscountedProduct(DiscountedProduct discountedProduct)
        {
            products.Remove(discountedProduct);
        }
        public override string ToString()
        {
            var Products = "";
            foreach (var prod in products)
            {
                Products += prod.ToString();
                Products += "\n----------\n";
            }
            return $"This order ID = {Id}\n" +
                $"Total price of this order = {TotalPrice():#####,##}\n" +
                $"This order was made by this user --->\n{user}\n" +
                $"\nThis order have this products --->\n{Products}";
        }
        public Order(User User)
        {
            user = User;
            products = new List<Product>();
        }
    }
}

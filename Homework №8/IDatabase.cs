namespace Homework__8
{
    internal interface IDatabase
    {
        public GenericKeeper<User> Users { get; }
        public GenericKeeper<Product> Products { get; }
        public GenericKeeper<DiscountedProduct> DiscountedProducts { get; }
        public GenericKeeper<Order> Orders { get; }

        public Task PrintDatabaseAsync();
        public void SaveUsers();
        public void SaveProducts();
        public void SaveDiscountedProducts();
        public void SaveOrders();

    }
}

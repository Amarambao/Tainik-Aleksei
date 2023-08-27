using Homework__7;

User Ivan = new User(1, "Ivanov", "Ivan", "Ivanovich", "+375123456789", "Sovietskaya");
//Console.WriteLine(Ivan.ToString());
User Boris = new User(2, "Borisov", "Boris", "Borisovich", "+375290987654", "Lenina");
//Console.WriteLine(Boris.ToString());
User Peter = new User(3, "Petrov", "Peter", "Petrovich", "+375210981256", "Stalina");
//Console.WriteLine(Peter.ToString());
User Vasilyi = new User(4, "Vasil'ev", "Vasilyi", "Vasil'evich", "+375251357924", "Molodeznaya");
//Console.WriteLine(Vasilyi.ToString());

Product Bread = new Product(11, "Bread", "Black", 2.55);
Product Bread1 = new Product(11, "Bread", "Black", 2.55);
//Console.WriteLine(Bread.Equals(Bread1));//равные друг другу
//Console.WriteLine(Bread.ToString());
Product Milk = new Product(12, "Milk", "Goat", 4.99);
//Console.WriteLine(Milk.ToString());
Product Tea = new Product(13, "Tea", "Green", 15.49);
//Console.WriteLine(Tea.ToString());
Product Cheese = new Product(14, "Cheese", "Belarus", 7.59);
//Console.WriteLine(Cheese.ToString());

DiscountedProduct DiscountedTea = new DiscountedProduct(113, "Tea", "Discounted green tea", 15.49, 85);
//Console.WriteLine(DiscountedTea.ToString());

Order IvanOrder = new Order(21, Ivan);
IvanOrder.AddProduct(Cheese); IvanOrder.AddProduct(Cheese); IvanOrder.AddProduct(Bread);
//Console.WriteLine(IvanOrder.ToString());
Order IvanOrder2 = new Order(22, Ivan);
IvanOrder2.AddProduct(DiscountedTea); IvanOrder2.AddProduct(DiscountedTea);
//Console.WriteLine(IvanOrder2.TotalPrice());

Order BorisOrder = new Order(22, Boris);
BorisOrder.AddProduct(Milk); BorisOrder.AddProduct(Tea); BorisOrder.AddProduct(Bread); BorisOrder.AddProduct(Bread);
//Console.WriteLine(BorisOrder.ToString());

Order PeterOrder = new Order(23, Peter);
PeterOrder.AddProduct(Tea); PeterOrder.AddProduct(Tea); PeterOrder.AddProduct(Tea); PeterOrder.AddProduct(Tea);
PeterOrder.RemoveProduct(Tea); PeterOrder.RemoveProduct(Tea); PeterOrder.RemoveProduct(Tea);
//Console.WriteLine(PeterOrder.ToString());

Order VasilyiOrder = new Order(24, Vasilyi);
VasilyiOrder.AddProduct(Cheese); VasilyiOrder.AddProduct(Tea); VasilyiOrder.AddProduct(Milk); VasilyiOrder.AddProduct(Bread);
//Console.WriteLine(VasilyiOrder.ToString());


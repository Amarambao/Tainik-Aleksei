using Homework__8;

class Program
{
    async static Task Main(string[] args)
    {
        IDatabase database = null;
        await Task.Run(() => database = DatabaseCreator.CreateDatabase());

        User user = null;

        while (true)
        {
            if (user == null)
            {
                //await Task.Run(() => Console.WriteLine("Enter ID"));
                Console.WriteLine("Enter ID");
                var userID = Convert.ToInt64(Console.ReadLine());
                user = database.Users.ShowItem().FirstOrDefault(user => user.Id == userID);

                if (user == null)
                {
                    Console.Write("Enter your surname: ");
                    var newSurname = Console.ReadLine();

                    Console.Write("Enter your name: ");
                    var newName = Console.ReadLine();

                    Console.Write("Enter your fathername: ");
                    var newFatherName = Console.ReadLine();

                    Console.Write("Enter your phone number: 375123456789");
                    var newPhoneNumber = Console.ReadLine();

                    Console.Write("Enter your adress: ");
                    var newAdress = Console.ReadLine();

                    var newUser = new User(newSurname!, newName!, newFatherName!, newPhoneNumber!, newAdress!);

                    database.Users.AddItem(newUser);

                    Console.WriteLine($"Your ID = {newUser.Id}. Welcome!");

                }
                else while (true)
                    {
                        Console.WriteLine("Enter command");
                        var Input = Console.ReadLine();

                        switch (Input)
                        {
                            case "showUsers":
                                Console.WriteLine(database.Users.PrintItems());
                                break;

                            case "showProducts":
                                Console.WriteLine(database.Products.PrintItems());
                                break;

                            case "showDiscountedProducts":
                                Console.WriteLine(database.DiscountedProducts.PrintItems());
                                break;

                            case "showOrders":
                                Console.WriteLine(database.Orders.PrintItems());
                                break;

                            case "addUser":
                                Console.Write("Enter your surname: ");
                                var newSurname = Console.ReadLine();

                                Console.Write("Enter your name: ");
                                var newName = Console.ReadLine();

                                Console.Write("Enter your fathername: ");
                                var newFatherName = Console.ReadLine();

                                Console.Write("Enter your phone number: 375123456789");
                                var newPhoneNumber = Console.ReadLine();

                                Console.Write("Enter your adress: ");
                                var newAdress = Console.ReadLine();

                                var newUser = new User(newSurname!, newName!, newFatherName!, newPhoneNumber!, newAdress!);
                                database.Users.AddItem(newUser);

                                database.SaveUsers();
                                break;

                            case "addProduct":
                                Console.WriteLine("Enter new product name: ");
                                var newProductName = Console.ReadLine();

                                Console.WriteLine("Enter new product description: ");
                                var newProductDescription = Console.ReadLine();

                                Console.Write("Enter new product price = ");
                                var result = double.TryParse(Console.ReadLine(), out double newProductPrice);

                                if (result)
                                {
                                    var newProduct = new Product(newProductName!, newProductDescription!, newProductPrice!);
                                    database.Products.AddItem(newProduct);
                                }

                                database.SaveProducts();
                                break;

                            case "addDiscountedProduct":
                                Console.WriteLine("Enter new product name: ");
                                var newDiscProductName = Console.ReadLine();

                                Console.WriteLine("Enter new product description: ");
                                var newDiscProductDescription = Console.ReadLine();

                                Console.Write("Enter new product price = ");
                                var result1 = double.TryParse(Console.ReadLine(), out double newDiscProductPrice);

                                Console.WriteLine("Enter current discount = ");
                                int CurrentDiscount;

                                var result2 = int.TryParse(Console.ReadLine(), out CurrentDiscount);
                                if (result1 && result2)
                                {
                                    var newDiscountedProduct = new DiscountedProduct(newDiscProductName!, newDiscProductDescription!, newDiscProductPrice!, CurrentDiscount!);
                                    database.DiscountedProducts.AddItem(newDiscountedProduct);
                                }

                                database.SaveDiscountedProducts();
                                break;

                            case "addOrder":
                                var newOrder = new Order(user);

                                Console.WriteLine("Enter product ID to choose products to order");
                                long productID;

                                do
                                {
                                    productID = Convert.ToInt64(Console.ReadLine());
                                    var product = database.Products.ShowItem().FirstOrDefault(user => user.Id == productID);

                                    if (product != null)
                                    {
                                        newOrder.AddProduct(product);
                                    }

                                    Console.WriteLine("If u want to order more products enter product ID");
                                } while (productID != null);

                                database.Orders.AddItem(newOrder);

                                database.SaveOrders();
                                break;

                            case "exit":
                                //на всякий оставил
                                //database.SaveUsers();
                                //database.SaveOrders();
                                //database.SaveProducts();
                                //database.SaveDiscountedProducts();
                                return;

                            default:
                                Console.WriteLine("Wrong input try again");
                                break;
                        };
                    }
            }
        }
    }
}

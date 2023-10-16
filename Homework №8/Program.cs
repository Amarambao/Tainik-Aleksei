using Homework__8;
using Newtonsoft.Json;

IDatabase database = DatabaseCreator.CreateDatabase();

var allUsers = database.Users.ShowItem();

User user = null;

void PrintDatabase()
{
    Console.WriteLine("Users");
    var Users = database.Users.ShowItem();
    foreach (User users in Users)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine(users.ToString());
    }
    Console.WriteLine();

    var Products = database.Products.ShowItem();
    foreach (var products in Products)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine(products.ToString());
    }
    Console.WriteLine();

    var DiscountedProducts = database.DiscountedProducts.ShowItem();
    foreach (var discountedProducts in DiscountedProducts)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine(discountedProducts.ToString());
    }
    var Orders = database.Orders.ShowItem();
    foreach (var orders in Orders)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine(orders.ToString());
    }
    Console.WriteLine();
}

PrintDatabase();

while (true)
{
    if (user == null)
    {   
        Console.WriteLine("Enter ID");
        long userID = Convert.ToInt64(Console.ReadLine());
        user = database.Users.ShowItem().FirstOrDefault(user => user.Id == userID);

        if (user == null)
        {
            Console.Write("Enter your surname: ");
            string newSurname = Console.ReadLine();
            Console.Write("Enter your name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter your fathername: ");
            string newFatherName = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string newPhoneNumber = Console.ReadLine();
            Console.Write("Enter your adress: ");
            string newAdress = Console.ReadLine();
            User newUser = new User(newSurname, newName, newFatherName, newPhoneNumber, newAdress);

            Console.WriteLine($"Your ID = {user.Id}. Welcome!");

            database.Users.AddItem(newUser);
        }
        else
        {
            Console.WriteLine("Enter command");
            string Input = Console.ReadLine();

            if (Input == "showUsers")
            {
                var Users = database.Users.ShowItem();
                foreach (User users in Users)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(users.ToString());
                }
                Console.WriteLine();
            }

            if (Input == "showProducts")
            {
                var Products = database.Products.ShowItem();
                foreach (var products in Products)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(products.ToString());
                }
                Console.WriteLine();
            }

            if (Input == "showDiscountedProducts")
            {
                var DiscountedProducts = database.DiscountedProducts.ShowItem();
                foreach (var discountedProducts in DiscountedProducts)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(discountedProducts.ToString());
                }
            }

            if (Input == "showOrders")
            {
                var Orders = database.Orders.ShowItem();
                foreach (var orders in Orders)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(orders.ToString());
                }
                Console.WriteLine();
            }

            if (Input == "addUser")
            {
                Console.Write("Enter your surname: ");
                string newSurname = Console.ReadLine();
                Console.Write("Enter your name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter your fathername: ");
                string newFatherName = Console.ReadLine();
                Console.Write("Enter your phone number: ");
                string newPhoneNumber = Console.ReadLine();
                Console.Write("Enter your adress: ");
                string newAdress = Console.ReadLine();
                User newUser = new User(newSurname, newName, newFatherName, newPhoneNumber, newAdress);
                database.Users.AddItem(newUser);
            }

            if (Input == "addProduct")
            {
                Console.WriteLine("Enter new product name: ");
                string newProductName = Console.ReadLine();
                Console.WriteLine("Enter new product description: ");
                string newProductDescription = Console.ReadLine();
                Console.Write("Enter new product price = ");
                double newProductPrice;
                bool result = double.TryParse(Console.ReadLine(), out newProductPrice);
                if (result)
                {
                    Product newProduct = new Product(newProductName, newProductDescription, newProductPrice);
                    database.Products.AddItem(newProduct);
                }
            }

            if (Input == "addDiscountedProduct")
            {
                Console.WriteLine("Enter new product name: ");
                string newProductName = Console.ReadLine();
                Console.WriteLine("Enter new product description: ");
                string newProductDescription = Console.ReadLine();
                Console.Write("Enter new product price = ");
                double newProductPrice;
                bool result1 = double.TryParse(Console.ReadLine(), out newProductPrice);
                Console.WriteLine("Enter current discount = ");
                int CurrentDiscount;
                bool result2 = int.TryParse(Console.ReadLine(), out CurrentDiscount);
                if (result1 && result2)
                {
                    DiscountedProduct newDiscountedProduct = new DiscountedProduct(newProductName, newProductDescription, newProductPrice, CurrentDiscount);
                    database.DiscountedProducts.AddItem(newDiscountedProduct);
                }
            }

            if (Input == "addOrder")
            {
                var newOrder = new Order(user);
                Console.WriteLine("Enter product ID to choose products to order");
                long productID;
                do
                {
                    productID = Convert.ToInt32(Console.ReadLine());
                    Product product = database.Products.ShowItem().FirstOrDefault(user => user.Id == productID);
                    if (product != null)
                    {
                        newOrder.AddProduct(product);
                    }
                    Console.WriteLine("If u want to order more products enter product ID");
                } while (productID != null);
                database.Orders.AddItem(newOrder);
            }

            if (Input == "exit")
            {
                database.Save();
                return;
            }
        }
    }
}
using Homework__6;

Order[] Orders = new Order[]
{
    new Order(2, "Borisov", "Boris", "Borisovich", "Milk", "Goat milk", 7.99, 9),
    new Order("+375 (25) 123-45-67", "Suchareva"),
    new Order(3, "Ivan", "Boris", "Dunnovich", "Icecream", "Vanilla", 5.25, 2)
};

Console.WriteLine(Orders[0].GetType());

var Ascending =  Orders.OrderBy(order => order.TotalPrice());

foreach (var order in Ascending)
{
    Console.WriteLine("{0:###.##}", order.TotalPrice());
}

Console.WriteLine(Orders[0] == Orders[1]);

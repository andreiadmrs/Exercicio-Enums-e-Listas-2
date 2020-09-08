using System;
using System.Globalization;
using Enum3.Entities;
using Enum3.Entities.Enums;

namespace Enum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("E-mail:");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY):");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.WriteLine("Order status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("How many items to this order?");
            int q = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status,client);
            


            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Product quantity:");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(item);
            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}

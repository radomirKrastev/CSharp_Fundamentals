namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var clientsData = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            var clients = new List<Person>();

            foreach (var client in clientsData)
            {
                var name = client.Split("=")[0];
                var money = double.Parse(client.Split("=")[1]);

                var person = new Person
                {
                    Name = name,
                    Money = money
                };

                clients.Add(person);
            }

            var productsData = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries );
            var products = new List<Product>();

            foreach (var product in productsData)
            {
                var name = product.Split("=")[0];
                var price = double.Parse(product.Split("=")[1]);

                var item = new Product
                {
                    Name = name,
                    Price = price
                };

                products.Add(item);
            }

            var command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                var personName = command[0];
                var productName = command[1];
                var productIndex = products.FindIndex(x => x.Name == productName);
                var personIndex = clients.FindIndex(x => x.Name == personName);
                bool isPurchasePossible = clients[personIndex].GetBuyResult
                    (clients[personIndex].Money, products[productIndex].Price);


                if (isPurchasePossible)
                {
                    clients[personIndex].AddProduct(products[productIndex]);
                    clients[personIndex].Money -= products[productIndex].Price;
                    Console.WriteLine($"{personName} bought {productName}");
                }

                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }

                command = Console.ReadLine().Split();
            }

            foreach (var person in clients)
            {
                if (person.ProductsBag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                
                else
                {
                    Console.Write($"{person.Name} - ");

                    for (int i = 0; i < person.ProductsBag.Count; i++)
                    {
                        if(i== person.ProductsBag.Count - 1)
                        {
                            Console.Write(person.ProductsBag[i].Name);
                        }
                        else
                        {
                            Console.Write(person.ProductsBag[i].Name + ", ");
                        }                        
                    }

                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}

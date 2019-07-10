namespace StoreBoxes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main()
        {
            var itemData = Console.ReadLine().Split(' ').ToList();
            var boxesList = new List<Box>();
            var itemsList = new List<Item>();

            while (itemData[0] != "end")
            {
                var serialNumber = itemData[0];
                var name = itemData[1];
                var quantity = int.Parse(itemData[2]);
                var price = double.Parse(itemData[3]);

                var item = new Item
                {
                    Name = name,
                    Price = price
                };

                var box = new Box
                {
                    SerialNumber = serialNumber,
                    Name = name,
                    Quantity = quantity,
                    Item=item,
                    Price = item.Price * quantity
                };

                itemsList.Add(item);
                boxesList.Add(box);

                itemData = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var box in boxesList.OrderByDescending(x=>x.Price))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }

}

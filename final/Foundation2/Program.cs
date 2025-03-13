using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Helaman Tillotson", "111 Southview Dr", "Harmony", "PA", "USA");
        order1.AddProduct("Boot", 1334, 45.99, 1);
        order1.AddProduct("Overwatch", 62, 59.99, 1);
        order1.AddProduct("Shirt", 10, 20, 5);

        Order order2 = new Order("Alejandro Martínez", "Calle Falsa 123", "Colonia Centro", "Ciudad de México", "México");
        order2.AddProduct("Shoe", 123, 30, 2);
        order2.AddProduct("Pant", 12, 25.99, 3);
        order2.AddProduct("Tire", 1001, 74.99, 4);

        Console.WriteLine($"Order1:\n{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\nTotal: ${order1.GetTotal()}");
        Console.WriteLine($"\n\nOrder2:\n{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\nTotal: ${order2.GetTotal()}");
    }
}
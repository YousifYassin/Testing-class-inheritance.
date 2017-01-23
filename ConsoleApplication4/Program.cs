using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.model;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> inventory = new List<object>();

            inventory.Add(new Fruit("apple", 5.4, 5));
            inventory.Add(new Fruit("banana", 2.1, 2));
            inventory.Add(new Vegetable("caroot", 6.6, 6));

            Console.WriteLine(inventory.Count+"\n");

            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.model
{
    class Fruit
    {
        public override string ToString()
        {
            return name + "\t" + Quantity + "\t" + wieght;
        }

        public Fruit()
        { }

        public Fruit(string name, double wieght, int quantity)
        {
            Name = name;
            Wieght = wieght;
            Quantity = quantity;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double wieght;
        private double Wieght
        {
            get { return wieght; }
            set { wieght = value; }
        }
        public int Quantity { set; get; }
    }
    class Vegetable : Fruit
    {
        public Vegetable()
        { }
        public Vegetable(string name, double wieght, int quantity) : base(name, wieght, quantity)
        { }
    }
}

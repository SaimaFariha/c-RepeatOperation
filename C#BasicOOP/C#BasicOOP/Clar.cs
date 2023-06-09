using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicOOP
{
    public enum Color 
    {
        Red,
        Green,
        Blue,
        Black,
    }
    internal class car
    {
        public Color color;
        public string name;
        public string brand;
        public DateTime year;

        public static int price;

        public void Start()
        { 
            Console.WriteLine("car has started");
        }
        public void Speed()
        {
            Console.WriteLine("Car speed is 180 kmph");
        }
    }
}

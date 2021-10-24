using System;

namespace FristTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product car = new Product(1, "araç");

            Console.WriteLine(car.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FristTestApp
{
    class Product
    {

        public int Id { get; }
        public string Name { get; }

        public Product(int Id, string Name)
        {
            this.Id = Id;
            Name = Name;
            this.run();
        }

        void run()
        {
            Console.WriteLine("sikişş varrr");
        }
    }
}

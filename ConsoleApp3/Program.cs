using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int count;

            Console.Write("name: ");
            name = Console.ReadLine();

            Console.Write("count: ");
            count = Convert.ToInt32(Console.ReadLine());



            var context = new ProductEntities();


            Product product = new Product()
            {
                name = name,
                count = count
            };
            context.Product.Add(product);

            try
            {

                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error accoucet");
                Console.WriteLine(e);
            }


            var myprod = from b in context.Product where b.name.StartsWith("l") select b;






        }
    }
}

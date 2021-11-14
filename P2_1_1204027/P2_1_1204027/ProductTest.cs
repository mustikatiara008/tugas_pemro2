using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204027
{
    class ProductTest
    {
        static void Main(String[] args)
        {
            Book product1 = new Book("Bool", "C# Object Oriented Solution", "300");
            DVD product2 = new DVD("Eternal Sunshine of the Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyTitle, product1.PageCount1);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} minutes duration", product2,MyType, product2.MyTitle, product2.Duration);
        }
    }
}

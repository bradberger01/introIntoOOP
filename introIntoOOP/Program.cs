using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introIntoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("Neko", "black", 3, 1, true);
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);
            cat1.Name = "Gato";
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Age);
            Console.WriteLine(cat1.Age);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>(1, "Richard", "Quetives");
            emp1.things = new List<string>() { "Richard", "Quetives", "was", "hired." };
            emp1.things.ForEach(i => Console.Write("{0} ", i));
            Console.ReadLine();

            Employee<int> emp2 = new Employee<int>(2, "Anahiza", "Carrillo");
            emp2.things = new List<int>() { 22, 35, 14, 47 };
            emp2.things.ForEach(i => Console.Write("{0} \n", i));
            Console.ReadLine();
        }
    }
}

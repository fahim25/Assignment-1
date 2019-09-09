using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address;

            Console.WriteLine("Please Enter Your Name:");
                name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age:");
                int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Address:");
            address = Console.ReadLine();

            Console.WriteLine("Please Enter Your Contract:");
            int contact = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name " + name + "");
            Console.WriteLine("Age " + age + "");
            Console.WriteLine("Address " + address + "");
            Console.WriteLine("Contact " + contact + "");

            Console.ReadKey();
        } 
    }
}

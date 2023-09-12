using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.USER_INPUTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Dumela " + firstname);
            Console.WriteLine("Enter Your Age ");
            string Age = Console.ReadLine();
            Console.WriteLine("You are " + Age + " years old. ");
            Console.WriteLine("Enter Your Place");
            String Place = Console.ReadLine();
            Console.WriteLine("You are from " + Place + " village");

            //read
            Console.ReadLine();
        }
    }
}

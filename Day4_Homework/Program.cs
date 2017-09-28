using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Rashida";
            //Console.WriteLine("Please enter your first name.");
            //string firstName = Console.ReadLine();
            //Console.WriteLine(firstName.Length);

            //string lastName = "McWilliams";
            //Console.WriteLine("Please enter your last name.");
            //string lastName = Console.ReadLine();
            //Console.WriteLine(lastName.Length);

            //if (firstName.Length > lastName.Length)
            //{
            //    Console.WriteLine("First is longer!");
            //}
            //else if (firstName == lastName)
            //{
            //    Console.WriteLine("Samesies.");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}

            string aName = "Ebony";
            string bName = "Ivory";

            if (aName == bName)
            {
                Console.WriteLine("The names are the same!");
            }
            else
            {
                Console.WriteLine("The names are different. Boo.");
            }

        }
    }
}

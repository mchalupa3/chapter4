using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            int num1, num2, num3;
            Console.WriteLine("enter an integer");
            numberString = Console.ReadLine();
            num1 = Convert.ToInt32(numberString);
            Console.WriteLine("Enter an integer");
            numberString = Console.ReadLine();
            num2 = Convert.ToInt32(numberString);
            Console.WriteLine("Enter an integer");
            numberString = Console.ReadLine();
            num3 = Convert.ToInt32(numberString);

            if(num1 == num2)
                if (num1 == num3)
                    Console.WriteLine("all three numbers are equal!");
                else
                    Console.WriteLine("First two are equeal");
            else
                if(num1 == num3)
                Console.WriteLine("First and last are equal");
            else
                if(num2 == num3)
                Console.WriteLine("last two are ewual");
                else
                    Console.WriteLine("no two numbers are equal");
                

        }
    }
}

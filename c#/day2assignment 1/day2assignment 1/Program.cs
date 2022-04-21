using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st num");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(n1 + " and " + n2 + " are equal");
            }
            else if (n1 != n2)
            {
                Console.WriteLine(n1 + " and " + n2 + " are not equal");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();

            //2
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine(n + "is Positive number");
            }
            else if (n < 0)
            {
                Console.WriteLine(n + "is Negative number");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();

            //3
            int number1, number2, result;
            char operation;
            Console.Write("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1 addititon");
            Console.WriteLine("2 subtraction");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two number is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two number is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("The multiplication of two number is : {0}", result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("The division of two number is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            // integers our numbers
            int num1 = numberGenerator.Next(1, 11);
            int num2 = numberGenerator.Next(1, 11);

            Console.WriteLine("What is " + num1 + " Times " + num2 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());


            if (answer == num1 * num2)
            {
                Console.WriteLine("Correct!");

                int responseIndex = numberGenerator.Next(1, 4);
    
                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("The answer was correct !");
                        break;
                    case 2:
                        Console.WriteLine("You was right!");
                        break;
                    default:
                        Console.WriteLine("This is default switch case!");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(answer - (num1 * num2));
                if (diff == 1)
                {
                    Console.WriteLine("So close !");
                }

                else if (diff <= 10)
                {
                    Console.WriteLine("You can do better then that");
                }

                else
                {
                    Console.WriteLine("You are not even close");
                }
            }
            return;
        }
    }
}

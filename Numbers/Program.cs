using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers game");
            while (true)
            {
                //first number
                Console.Write("Enter first number : ");

            int number1 = 0;
            number1 = Convert.ToInt32(Console.ReadLine());


            //second number
            Console.Write("Enter seccond number : ");

            int number2 = 0;
            number2 = Convert.ToInt32(Console.ReadLine());
            //options
            Console.Write("Pick options 1.+ 2.- 3.* 4./ 5.% 6.~ :  ");
            string option = Console.ReadLine();
            Console.Write("The result is : ");
            if (option == "1" || option == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            if (option == "2" || option == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            if (option == "3" || option == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            if (option == "4" || option == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            if (option == "5" || option == "%")
            {
                Console.WriteLine(number1 % number2);
            }
            if (option == "6" || option == "~")
            {
                    //   Environment.Exit(0);
                    break;
                }
      
              

            }

        
            //solution

            
        }

           }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for if/else statement
            bool user = true;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\tWelcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("\t\t\t\t==============================================");

            Console.Beep(120,5000);
            
            while (user)
            {
                //getting user input
                Console.ResetColor();
                Console.WriteLine("Enter the length of the room: ");

                    double length = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter the width of the room: ");

                    double width = Convert.ToDouble(Console.ReadLine());

                //process of getting area
                double area = length * width;
                //output of area
                Console.WriteLine("The area of the room is: " + area);

                //process of getting perimeter
                double perimeter = (length * 2) + (width * 2);
                //output of perimeter
                //Console.WriteLine("The perimeter is: " + perimeter);
                Console.WriteLine($"The perimeter is: {perimeter} ");




                Console.WriteLine("Do you want to keep measuring: y/n");
                var input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    user = false;
                    Console.WriteLine("See you later");
                    Console.ReadLine();
                }

            }


                

                    
            
               
               


               

               
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput;
            int number, result = 0, counter = 0;
            float average = 0;
            bool option;
            do
            {
                counter++;
                Console.WriteLine("Please enter a number");
                numberInput = Console.ReadLine();
                number = int.Parse(numberInput);
                result = result + number;
                Console.WriteLine("if do you want plus other number press y");
                numberInput = Console.ReadLine();
                option = (numberInput == "y") ? true : false; 
            }
            while (option);
            Console.WriteLine("the average is :");
            average = result / counter;
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}

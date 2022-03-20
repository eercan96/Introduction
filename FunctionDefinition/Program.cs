using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDefinition
{
    class Program
    {

        double number1 = 0;
        double number2 = 0;

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Display();
            
            Console.WriteLine(prog.Addition().ToString());
            Console.ReadKey();
            

        }

        double Addition()
        {
            double add = number1 + number2;
            return add;


        }
        void Display()
        {
            Console.WriteLine("enter the first number");
            number1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            number2 = Convert.ToDouble(Console.ReadLine());
        }

    }
}

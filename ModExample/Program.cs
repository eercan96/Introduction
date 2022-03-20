using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
           
            //Console.WriteLine(prog.IsEven());
            //Console.WriteLine(prog.IsOdd());
            Console.WriteLine(prog.Mod2());
            Console.ReadLine();

        }

        bool IsOdd()
        {
            float number = Convert.ToSingle(Console.ReadLine());
            int roundUp = Convert.ToInt32(number);
            return roundUp % 2 == 1;

        }
        bool IsEven()
        {
            float number = Convert.ToSingle(Console.ReadLine());
            int roundUp = Convert.ToInt32(number);
            return roundUp % 2 == 0;

        }
        float Mod2()
        {
            float number = Convert.ToSingle(Console.ReadLine());
            return number % 2;
            //noktadan sonrasını almaz.
        }
    }
}

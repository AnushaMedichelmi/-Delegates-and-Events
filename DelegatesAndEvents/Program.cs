using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int value);

namespace DelegatesAndEvents
{
    internal class Program
    {
        static int number = 5;
        static void Main(string[] args)
        {
            NumberChanger numberOne = new NumberChanger(AddNumber);
            NumberChanger numberTwo = new NumberChanger(MultiplyNumber);
            numberOne(4);
            Console.WriteLine(GetNumber());
            numberTwo(6);
            Console.WriteLine(GetNumber());
            Console.ReadLine();

        }
        public static int AddNumber(int X)
        {
             number+=X;
            return number;
        }

        public static int MultiplyNumber(int Y)
        {
            number *= Y;
            return number;
        }

        public static int GetNumber()
        {
            return number;
        }
    }
}

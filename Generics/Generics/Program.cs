using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            bool IsEqual;
            IsEqual = ClsCalculator.AreEqual(10, 20);
            PrintMessage(IsEqual);
            IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);

           

            Console.ReadKey();

        }

        private static void PrintMessage(bool IsEqual)
        {
            if (IsEqual)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("Both are Not Equal");
        }


    }

    //Exercise 1 rewrite the AreEqual method 
    //using generics to make all 3 methods work
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}

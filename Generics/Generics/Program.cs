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
            PrintMessage(IsEqual);
            IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            PrintMessage(IsEqual);

            Console.WriteLine($"Test returns : {ClsCalculator.Test<string>(10)}");

            Console.WriteLine($"Test returns : {ClsCalculator.Test<bool>(20)}");

            Console.WriteLine($"Test returns : {ClsCalculator.Test<double>(30)}");


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
        public static bool AreEqual<T>(T value1, T value2)
        {
            Console.WriteLine($"Value 1 : {value1}, Value 2 : {value2}");
            return value1.Equals(value2);
        }

        //Return type of method generic
        public static T Test<T>(int val)
        {
            Console.WriteLine($"Test - Integer : {val}, Type of method : {typeof(T)} ");
            return (T)Convert.ChangeType(val, typeof(T));
        }
    }
}

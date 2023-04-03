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


            var person = new Person() { Id = 1, Name = "John", Address = "Park Lane" };
            var animal = new Animal() { Id = 1, Name = "Doggo", Address = "Home" };
            var tree = new Tree() { Id = 1, Name = "Rose", Location = "Garden" };

            //Implement and Test all the methods
            //new Tree().Create();
            //new Tree().Read();
            //new Tree().Update();
            //new Tree().Delete(); 

            //new Person().Create();
            //new Person().Read();
            //new Person().Update();
            //new Person().Delete();

            //new Animal().Create();
            //new Animal().Read();
            //new Animal().Update();
            //new Animal().Delete();

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

    //Exercise 2
    //1.Create an interface for the 3 classes,Person,Tree and Animal for the CRUD methods
    //2.Create an abstract class for the 3 classes,Person,Tree and Animal for the CRUD methods
}

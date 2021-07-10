using System;
using HouseFunction;

namespace Test_Cases
{
    class Program
    {
        private static string _first = "Hello";
        private static string _last = "World!";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fool Me Twice Merch!");
            
            Test obj = new Test();                  //instantiates Test class
            obj.SomeMethod();                       //Method called
            
            Console.WriteLine(_first +_last);
            Console.WriteLine(obj.SomeMethod());

            // Console.WriteLine(args[0]);

            //House Example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue.");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "House Extraordinaire";
            Console.WriteLine(objHouse.Name);

            Console.WriteLine("Hello."=="Hello.");
            
            Collection.CollectionMain();

        }
    }

    class Test
    {
        public string SomeMethod()
            {
            
                return "Hello World SomeMethod.";
            }
    }
}

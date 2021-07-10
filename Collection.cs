using System; 
using System.Collections;
using System.Collections.Generic;

namespace Test_Cases
{
    public class Collection
    {
        //Generic field

        static List<string> strings = new List<string>();

        //Non-generic field
        static ArrayList arrays = new ArrayList();
    
    
        public static void CollectionMain()
        {
            Console.WriteLine("===Collection Demo===");
            Console.WriteLine("===List Demo===");
            
            //We are adding string elements to our strings List.
            strings.Add("First element.");
            strings.Add("Second element.");
            strings.Add("Third element.");

            //Ways to go through a list.

//For Each
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

//For Loop
            for (int i = 0; i < strings.Count; i+=2)
            {
                Console.WriteLine("The current index is " + i + ".");
                Console.WriteLine(strings[i]);
            }

//While Loop
            int x = 0;
            while (x < strings.Count)
            {
                Console.WriteLine(strings[x]);
                x++;
            }

            Console.WriteLine("===Array List Demo===");
            arrays.Add(5);
            arrays.Add("Some String.");
            arrays.Add(true);

            foreach (var item in arrays)
            {
                Console.WriteLine(item);
            }
        }
    }
}
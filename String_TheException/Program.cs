using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_TheException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings Can Look Like Values
            string a = "immutable";
            string b = "immutable";

            Console.WriteLine(a == b);

            Object o1 = new Object();
            Object o2 = new Object();

            Console.WriteLine(o1 == o2);

            // Strings can be Null or Empty or Unassigned

            // Unassigned
            string s;
            // Null
            string s2 = null;
            // Empty string
            string s3 = "";
            // Also empty string
            string s4 = String.Empty;
            // This prints true
            Console.WriteLine(s3 == s4);

            Console.WriteLine("enter a string: ");

            string x = Console.ReadLine();

            if (String.IsNullOrEmpty(x))
            {
                Console.WriteLine("You didn't enter anything!");
            }
            else
            {
                Console.WriteLine("Thank you for your submission!");
            }

            string hello = "Hello World";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.Contains("o"));

            // String as Class
            string lyrics =
                "Dollie, Dollie, bo-bollie,\n" +
                "Banana-fana fo-follie\n" +
                "Fee-fi-mo-mollie\n" +
                "Dollie!";

            // Call `Replace()` here
            lyrics = lyrics.Replace("ollie", "ana");
            Console.WriteLine(lyrics);

            // Example 1
            string dog = "chihuahua";
            string tinyDog = dog;
            dog = "dalmation";
            Console.WriteLine(dog);
            // Output: "dalmation"
            Console.WriteLine(tinyDog);
            // Output: "chihuahua"

            // Example 2
            string s1 = "Hello ";
            string sss = s1;
            s1 += "World";
            Console.WriteLine(s1);
            // Output: "Hello World"
            Console.WriteLine(sss);
            // Output: "Hello"

            
        
            //to keep console open
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Developer");

            int x;
            int y;
            int answer;

            x = 7;
            y = 3;
            answer = x + y;
            Console.WriteLine("The sum of 7 + 3 is : " + answer);

            Console.Write("Please type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Please type your last name: ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);

            Console.WriteLine("Please chose your preferrred programming language");
            Console.WriteLine("1 : Php");
            Console.WriteLine("2 : Python");
            Console.WriteLine("3 : c#");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You have selected Php";
            }
            else if (userValue == "2")
            {
                message = "You have selected Python";
            }
            else if (userValue == "3")
            {
                message = "You have selected c#";
            }
            else
            {
                message = "You didnt input a correct value";
            }
            Console.WriteLine(message);

            Console.WriteLine("Please chose your preferrred programming language version");
            Console.WriteLine("1 : 1.1");
            Console.WriteLine("2 : 3.5");
            Console.WriteLine("3 : 5.7");

            string version = Console.ReadLine();
            string versionMessage = (version == "1") ? "1.1" : (version == "2") ? "3.5" : (version == "3") ? "5.7" : "Your version doesnt exist";

            Console.WriteLine("The version you selected is " + versionMessage);
            Console.WriteLine("{0} is a very good version", versionMessage);

            Console.WriteLine("Press return to run your first program!");
            Console.ReadLine();

            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found 7");
                    break; //break causes the code to jump out of the foor loop.
                }
            }

            Console.WriteLine("Press return to print out your families names :");
            Console.ReadLine();

            string[] names = new string[] { "Joe", "Annette", "Kevin", "Declan" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Type in your details below and see them printed out backwards!");

            Console.WriteLine("Whats your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Whats your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string from = Console.ReadLine();

            DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(from));

            Console.WriteLine();

            string text = "This is to show an example of an over loaded method. Two methods called the same but have different input parameters, so two different methods";
            DisplayResults(text);

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResults(string reversedFirstName, string reversedLastName, string reversedFrom)
        {
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedFrom));
        }

        private static void DisplayResults(string message)
        {
            Console.Write(message);
        }
    }
}

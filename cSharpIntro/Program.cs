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
            bool displaymenu = true;

            while (displaymenu)
            {
                displaymenu = MainMenu();
                Console.ReadLine();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a programme to run:");
            Console.WriteLine("1) Show the sum equal to 10");
            Console.WriteLine("2) Type and print your name");
            Console.WriteLine("3) Chose your preferrred programming language");
            Console.WriteLine("4) Chose your preferrred programming version");
            Console.WriteLine("5) Run your first for loop");
            Console.WriteLine("6) Loop through array to print out your families names");
            Console.WriteLine("7) Type in details and show backwards");
            Console.WriteLine("8) Run overloading method");
            Console.WriteLine("9) Print numbers");
            Console.WriteLine("10) Guessing game");
            Console.WriteLine("11) Close programme");

            string result = Console.ReadLine();
            if (result == "1")
            {
                SumToTen();
                return true;

            }
            else if (result == "2")
            {
                EnterName();
                return true;
            }
            else if (result == "3")
            {
                PrefferedProgrammingLanguage();
                return true;
            }
            else if (result == "4")
            {
                PrefferedProgrammingVersion();
                return true;
            }
            else if (result == "5")
            {
                RunForLoop();
                return true;
            }
            else if (result == "6")
            {
                LoopThroughArray();
                return true;
            }
            else if (result == "7")
            {
                ShowDetailsBackwards();
                return true;
            }
            else if (result == "8")
            {
                ShowOverloadedMethod();
                return true;
            }
            else if (result == "9")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "10")
            {
                GuessingGame();
                return true;
            }
            else if (result == "11")
            {
                Console.Write("Please enter to exit! ");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void SumToTen()
        {
            int x;
            int y;
            int answer;

            x = 7;
            y = 3;
            answer = x + y;
            Console.WriteLine("The sum of 7 + 3 is : " + answer);
        }

        private static void EnterName()
        {
            Console.Write("Please type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Please type your last name: ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
        }

        private static void PrefferedProgrammingLanguage()
        {
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
        }

        private static void PrefferedProgrammingVersion()
        {
            Console.WriteLine("Please chose your preferrred programming language version");
            Console.WriteLine("1 : 1.1");
            Console.WriteLine("2 : 3.5");
            Console.WriteLine("3 : 5.7");

            string version = Console.ReadLine();
            string versionMessage = (version == "1") ? "1.1" : (version == "2") ? "3.5" : (version == "3") ? "5.7" : "Your version doesnt exist";

            Console.WriteLine("The version you selected is " + versionMessage);
            Console.WriteLine("{0} is a very good version", versionMessage);
        }

        private static void RunForLoop()
        {
            Console.WriteLine("Press return to run your first program!");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found 7");
                    break; //break causes the code to jump out of the for loop.
                }
            }
        }

        private static void LoopThroughArray()
        {
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
        }

        private static void ShowDetailsBackwards()
        {
            Console.WriteLine("Type in your details below and see them printed out backwards!");

            Console.WriteLine("Whats your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Whats your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string from = Console.ReadLine();

            DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(from));

        }

        private static void ShowOverloadedMethod()
        {
            string text = "This is to show an example of an over loaded method. Two methods called the same but have different input parameters, so two different methods";
            DisplayResults(text);
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
            while (incorrect);
                Console.WriteLine("Correct! It took you {0} guesses", guesses);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomClass
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                k = i.ToString();
            }
            ScopeMethod();
            /*
            Car myCar = new Car();
            myCar.Make = "Opel";
            myCar.Model = "Astra";
            myCar.Year = 2007;
            myCar.Color = "Blue";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
            */

            Car mySecondCar = new Car("Volvo", "V40", 2007, "Navey");
            Console.WriteLine("{0} {1} {2} {3}", mySecondCar.Make, mySecondCar.Model, mySecondCar.Year, mySecondCar.Color);

            Car.MyMethod();
            mySecondCar.ReturnContentFromPrivateMethod("Beetal");
            Console.ReadLine();
        }

        static void ScopeMethod()
        {
            Console.WriteLine("Printing out the value of k :" + k);
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 1000.0M;
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public decimal DetermineMarketValue()
        {
            decimal carvalue;

            if (Year > 2006)
            {
                carvalue = 2000;
            }
            else
            {
                carvalue = 1000;
            }

            return carvalue;
        }

        public static void MyMethod() /* the static method means it is just a utility method for example. I cant access The Car class properties inside a static method, however I can in the method above as it is not a static method. Look up video 15 for refernce. Very good video */
        {
            Console.WriteLine("Called the static MyMethod");
        }

        public void ReturnContentFromPrivateMethod(string make)
        {
            Make = make;
            
            Console.WriteLine(privateMethod(Make));
        }

        private string privateMethod(string car_make)
        {
            return "Text from private method called from public method outside the Car class with Car class property Make set to : " + car_make;
        }
    }
}

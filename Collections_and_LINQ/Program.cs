using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyata";
            car1.Model = "Starlet";
            car1.VIN = "123";

            Car car2 = new Car();
            car2.Make = "Opel";
            car2.Model = "Astra";
            car2.VIN = "456";

            // Object initializer
            // No need for a Constructor
            Car car3 = new Car() { Make = "Bmw", Model = "M3", VIN = "d4" };
            Car car4 = new Car() { Make = "Ford", Model = "Focus", VIN = "d15" };
            ///////////////////////////

            List<Car> myCarList = new List<Car>(); //A list is a type of collection which is an array. A list is the most popular forms of array as you can only work with one data type which in this case is Car
            myCarList.Add(car1);
            myCarList.Add(car2);
            myCarList.Add(car3);
            myCarList.Add(car4);

            foreach (Car car in myCarList)
            {
                Console.WriteLine(car.Make);
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["456"].Make); // Use a dictionary to search unique elements from an object and when its a match I can access all the elements within that object

            // Another example of creating an array
            string[] names = { "Declan", "Kevin", "Joe", "Annette" };

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Fiat", Model = "Punto", VIN = "dpo" },
                new Car { Make = "Renault", Model = "Clio", VIN = "iasa" }
            };
            ////////////////////////
            


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }
    }
}

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
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };
            ////////////////////////

            // LINQ query
            var bmws = from car in myCars where car.Make == "BMW" select car;
            Console.WriteLine("The results of the LINQ query");
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            var carsDecending = from car in myCars orderby car.Year descending select car;
            Console.WriteLine("The results of the LINQ query with decending");
            foreach (var car in carsDecending)
            {
                Console.WriteLine(car.Year);
            }

            // LINQ method
            var fords = myCars.Where(p => p.Make == "Ford" && p.Year == 2008); // we use var because we dont know what data type is been returned from the query
            Console.WriteLine("The results of the LINQ method");
            foreach (var car in fords)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            var carsDecendingV2 = myCars.OrderByDescending(p => p.Year); // we use var because we dont know what data type is been returned from the query
            Console.WriteLine("The results of the LINQ method with decending");
            foreach (var car in carsDecendingV2)
            {
                Console.WriteLine(car.Year);
            }

            Console.WriteLine("Print out the first BMW");
            var firstBmw = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine("The first bmw is : " + firstBmw.Year);

            Console.WriteLine("True false query method");
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            Console.WriteLine("An example of a one line foreach statement with a LINQ method");
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }
    }
}

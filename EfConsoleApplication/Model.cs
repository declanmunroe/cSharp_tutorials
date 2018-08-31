using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfConsoleApplication
{
    public class Person
    {
        public int PersonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime BirthDate { get; set; }
    }

    public class Todo
    {
        public int TodoId { get; set; }

        public string Item { get; set; }

        public string Completed { get; set; }

        
    }

    public class Video
    {
        public int id { get; set; }

        public string title { get; set; }

        public string genre { get; set; }


    }

    public class Family
    {
        public int id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }


    }
}

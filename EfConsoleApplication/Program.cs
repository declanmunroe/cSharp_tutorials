namespace EfConsoleApplication
{
    using System;
    using Microsoft;
    public class Program
    {
        public static void Main(string[] args)
        {
            PerformDatabaseOperations();
            PerformDatabaseTodo();
            PerformDatabaseVideo();
            PerformDatabaseFamily();
            Console.Write("Person saved !");
            Console.Write("Todo item saved !");
            Console.Write("Video item saved !");
            Console.Write("Family added item saved !");
            Console.ReadLine();
        }

        /// <summary>
        ///     The perform database operations.
        /// </summary>
        public static void PerformDatabaseOperations()
        {
            using (var db = new PersonDbContext())
            {
                var person = new Person
                {
                    FirstName = "Bob",
                    LastName = "Mirphy",
                    BirthDate = DateTime.Now
                };

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public static void PerformDatabaseTodo()
        {
            using (var db = new TodoDbContext())
            {
                var todo = new Todo
                {
                    Item = "Sql Server",
                    Completed = "Yes"
                };

                db.Todos.Add(todo);
                db.SaveChanges();
            }
        }

        public static void PerformDatabaseVideo()
        {
            using (var db = new VideoDbContext())
            {
                var video = new Video
                {
                    title = "Better Call Saul",
                    genre = "Comedy"
                };

                db.Videos.Add(video);
                db.SaveChanges();
            }
        }

        public static void PerformDatabaseFamily()
        {
            using (var db = new FamilyDbContext())
            {
                var family = new Family
                {
                    first_name = "Joseph",
                    last_name = "Munroe"
                };

                db.Families.Add(family);
                db.SaveChanges();
            }
        }
    }
}

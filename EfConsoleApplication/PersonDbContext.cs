using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EfConsoleApplication
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("name=EFpersonConn")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }

    public class TodoDbContext : DbContext
    {
        public TodoDbContext() : base("name=EFpersonConn")
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }

    public class VideoDbContext : DbContext
    {
        public VideoDbContext() : base("name=EFpersonConn")
        {

        }

        public DbSet<Video> Videos { get; set; }
    }

    public class FamilyDbContext : DbContext
    {
        public FamilyDbContext() : base("name=EFpersonConn")
        {

        }

        public DbSet<Family> Families { get; set; }
    }
}

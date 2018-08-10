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
}

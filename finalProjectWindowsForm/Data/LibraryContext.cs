using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using finalProjectWindowsForm.Models;
using System.Data.SqlClient;


namespace finalProjectWindowsForm.Data
    
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("DefaultConnection")
        {

            Database.SetInitializer(new DropCreateDatabaseAlways<LibraryContext>());
        }
        public DbSet<User> User{ get; set; }
        public DbSet<Models.Book> Book { get; set; }
        public DbSet<Models.Person> Person { get; set; }

        public DbSet<Managment> Management { get; set; }

        public DbSet<Models.Order> Order{ get; set; }
 
    }
}
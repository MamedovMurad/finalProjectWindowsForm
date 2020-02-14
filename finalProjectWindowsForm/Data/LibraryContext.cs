using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using finalProjectWindowsForm.Models;
using finalProjectWindowsForm.Forms;
using System.Data.SqlClient;


namespace finalProjectWindowsForm.Data
    
{
    class LibraryContext : DbContext
    {
        public LibraryContext() : base("DefaultConnection")
        {


        }
        public DbSet<User> User{ get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Person> Person { get; set; }

        public DbSet<Managment> Management { get; set; }

        public DbSet<Buy> Purchase { get; set; }
 
    }
}
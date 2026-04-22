using FirstCrudOperationAPi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCrudOperationAPi
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }




        public DbSet<User> Users{ get; set; }

        //public DbSet<Product> Products { get; set; }
    }
}


//why we use using keyword in c#?

// using keyword in C# is used to include namespaces in the code.
// It allows you to access classes, methods, and other members defined in those namespaces without having to specify the full namespace path each time. This helps to make the code cleaner and more readable. For example, instead of writing System.Console.WriteLine(), you can simply write Console.WriteLine() after including the System namespace with the using keyword.
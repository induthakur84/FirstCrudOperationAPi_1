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
    }
}


//why we use using keyword in c#?

// using keyword in C# is used to include namespaces in the code.
// It allows you to access classes, methods, and other members defined in those namespaces without having to specify the full namespace path each time. This helps to make the code cleaner and more readable. For example, instead of writing System.Console.WriteLine(), you can simply write Console.WriteLine() after including the System namespace with the using keyword.




//What are the four pillars of object-oriented programming (OOP)?   
// The four pillars of object-oriented programming (OOP) are: A PIE
// 1. Abstraction: It is the process of hiding the implementation details and showing only the functionality to the user. It allows us to focus on what an object does instead of how it does it.
// 2. Encapsulation: It is the process of wrapping the data and the code that manipulates the data into a single unit called a class. It helps to protect the data from unauthorized access and modification.
// 3. Inheritance: It is the process by which one class can inherit the properties and behaviors of another class. It promotes code reusability and establishes a natural hierarchical relationship between classes.
// 4. Polymorphism: It is the ability of an object to take on many forms. It allows objects of different classes to be treated as objects of a common superclass. It promotes flexibility and extensibility in the code.
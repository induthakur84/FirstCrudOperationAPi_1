using FirstCrudOperationAPi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstCrudOperationAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        //Contructor is a special member function which is automcatically when we create an object of the class. it is used to initialize the object of the class. it has the same name as the class and it does not have a return type. it can be parameterless or it can have parameters. in this case we are using parameterized constructor to inject the dependency of the ApplicationDbContext class.
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Get : api/User/GetAll

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);  //200
        }
        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user); //200
            //1000
        }
    }
}


// What are http methods in web development?
//http Get


//[httpget]-- it is used to get or retrieve data from the database .

//http Post--- it is used to create or add new data to the database .
//http Put--- it is used to update or modify existing data in the database .
//http Delete--- it is used to delete or remove data from the database .

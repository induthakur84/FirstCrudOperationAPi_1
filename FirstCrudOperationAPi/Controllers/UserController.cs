using FirstCrudOperationAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public  async IActionResult GetAll( )
        {
            var users =await _context.Users.ToListAsync();
            return Ok(users);  //200
        }

        //Get : api/User/GetById/1
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound(); //404
            }
            return Ok(user); //200
        }

        //Sync programming


        //one task
        // multiple threads working


        //one thread getall records from the database  it will 2 minutes

        // your thead a is block in 2 minutes



        //Async programming

        //one task
        //multiple threads working

        //one thread getting records from it will 2 minutes that with async wait but it will release the thread A  it goes to thead pool, after 2 mintues
        /// you are getting the record that any available thread in thead pool to show the list thead c



      

        //Post : api/User/Add
        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user); //200
            //1000
        }

        [HttpPut("{id}/Update")]
        public IActionResult Update(int id, User user)
        {
            if (id == null)
            {
                return BadRequest();//400
            }
            var updateUser = _context.Users.Find(id);
            if (updateUser == null)
                return NotFound();
            updateUser.Name = user.Name;
            updateUser.Email = user.Email;
            //_context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        [HttpDelete("{id}/Delete")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok("Record deleted successfull");

        }
    }
}


// what is async and await 











// What are http methods in web development?
//http Get


//[httpget]-- it is used to get or retrieve data from the database .

//http Post--- it is used to create or add new data to the database .
//http Put--- it is used to update or modify existing data in the database .
//http Delete--- it is used to delete or remove data from the database .

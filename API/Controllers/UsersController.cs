using Microsoft.AspNetCore.Mvc;
namespace API.Controllers{

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
   

   private readonly DataContext _context;

    public UsersController(DataContext context){
         _context=context;
    
   
    }
    
       

    [HttpGet(Name = "")]
    public IEnumerable<AppUser> Get()
    {
        var users=_context.Users.ToList();
    return users;
    }
}
}
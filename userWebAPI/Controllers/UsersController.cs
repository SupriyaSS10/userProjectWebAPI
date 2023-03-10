using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace UsersController;
using Model;
using userWebAPI.DAL;

[ApiController]
[Route("api/[controller]")]

public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;


    public UsersController(ILogger<UsersController> logger)

    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<User> GetAllUsers()
    {
        List<User> users = UserDataAccess.GetAllUsers();
        return users;
    }

   [Route("{id}")]
    [HttpGet]
    [EnableCors()]
public ActionResult<User>GetOneUser(int id)
{
    User users=UserDataAccess.GetUserById(id);
    return users;
}

[HttpPost]
[EnableCors()]

public IActionResult InsertNewUser(User user)
{
    UserDataAccess.SaveNewUser(user);
    return Ok(new {message="User created"});
}

[Route("{id}")]
[HttpDelete]
[EnableCors()]

public IActionResult DeleteOneUser(int id)
{
    UserDataAccess.DeleteUserById(id);
    return Ok(new { message="User deleted"});
}
}

    
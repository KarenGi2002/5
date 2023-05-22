using Microsoft.AspNetCore.Mvc;

namespace vacaciones.Controllers;

[ApiController]
[Route("[Controller]")]
public class homeController: ControllerBase{

    vacacionesContext dbcontext;

    public homeController(vacacionesContext db){
        dbcontext=db;

    }

    [HttpGet]
    [Route("Conndb")]
    public IActionResult Conndb(){
        dbcontext.Database.EnsureCreated();
        return Ok();
    }
}
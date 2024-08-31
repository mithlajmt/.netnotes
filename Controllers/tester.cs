using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] //The Route attribute in the controller specifies the base route for all the endpoints in this controller.
    //The[controller] placeholder is replaced with the name of the controller(minus the Controller suffix). For tester, the base route would be api/MyTest. 
   
    [ApiController]////mark the controller class as 
    //an api controller indicating its responsible for handle http requests
    //ffect: Enables features like automatic model validation, route template binding, and problem details for error handling. It helps ensure a consistent and predictable API behavior.
    public class tester : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("vannedaa ninte okke appan");
        }

    }
}

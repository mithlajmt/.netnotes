using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Required to use List


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] //The Route attribute in the controller specifies the base route for all the endpoints in this controller.
    //The[controller] placeholder is replaced with the name of the controller(minus the Controller suffix). For tester, the base route would be api/MyTest. 
   
    [ApiController]////mark the controller class as 
    //an api controller indicating its responsible for handle http requests
    //ffect: Enables features like automatic model validation, route template binding, and problem details for error handling. It helps ensure a consistent and predictable API behavior.
    public class tester : ControllerBase //This line declares a class named tester that inherits from ControllerBase.
    {// This is a base class for API controllers. It provides common functionality like returning HTTP responses. Unlike Controller, it doesn't include view-related functionality, making it more lightweight for APIs
        [HttpGet]
        public IActionResult Get()
        {
            // Initialize a List of KeyValuePair<string, string> to store the headers
            var test = new List<KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>();

            // Loop through the headers and add them to the list
            foreach (var head in Request.Headers)
            {
                test.Add(head);
            }


            // Return the list of headers in the response
            return Ok(test);
        }

    }
}

using DCI.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;


namespace DCI.Web.Controllers
{
    /// <summary>
    /// Base Controller for every Controller in overall application
    /// NOTE : Please use this Controller not use the  ControllerBase directly. 
    /// </summary>


    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]

    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        /// Method for returning the response to API
        /// </summary>
        /// <param name="objResponse"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<IActionResult> SendResponse(ResponseModel objResponse)
        {
            return objResponse.ResponseCode == 200 ? Ok(objResponse) : Unauthorized(objResponse);
        }
    }
}


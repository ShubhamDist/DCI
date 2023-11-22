
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Screen;
using DCI.Services.Abstractions.Master.Screen;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Screen
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenController : BaseController
    {
        private readonly IScreenService _screenService;
        public ScreenController(IScreenService screenService) => _screenService = screenService;

        #region Screen                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Screen                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _screenService.GetScreenAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Screen by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _screenService.GetScreenByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Screen                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] ScreenEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _screenService.SaveScreenAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Screen                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] ScreenEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _screenService.UpdateScreenAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Screen                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _screenService.DeleteScreenAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
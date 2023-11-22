using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Module;
using DCI.Services.Abstractions.Master.Module;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Module
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : BaseController
    {
        private readonly IModuleService _moduleService;
        public ModuleController(IModuleService moduleService) => _moduleService = moduleService;

        #region Module                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Module                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _moduleService.GetModuleAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Module by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _moduleService.GetModuleByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Module                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] ModuleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _moduleService.SaveModuleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Module                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] ModuleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _moduleService.UpdateModuleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Module                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _moduleService.DeleteModuleAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
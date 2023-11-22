
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.State;
using DCI.Services.Abstractions.Master.State;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.State
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : BaseController
    {
        private readonly IStateService _stateService;
        public StateController(IStateService stateService) => _stateService = stateService;

        #region State                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All State                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stateService.GetStateAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get State by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stateService.GetStateByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add State                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] StateEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stateService.SaveStateAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update State                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] StateEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stateService.UpdateStateAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate State                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stateService.DeleteStateAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.SubModule;
using DCI.Services.Abstractions.Master.SubModule;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.SubModule
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class SubModuleController : BaseController
    {
        private readonly ISubModuleService _subModuleService;
        public SubModuleController(ISubModuleService subModuleService) => _subModuleService = subModuleService;

        #region SubModule                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All SubModule                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.GetSubModuleAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get SubModule by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.GetSubModuleByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        [Route("GetSubModuleByModuleId")]
        [HttpGet]
        public async Task<IActionResult> GetSubModuleByModuleId(int ModuleID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.GetSubModuleByModuleIdAsync(ModuleID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add SubModule                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SubModuleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.SaveSubModuleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update SubModule                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SubModuleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.UpdateSubModuleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate SubModule                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _subModuleService.DeleteSubModuleAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
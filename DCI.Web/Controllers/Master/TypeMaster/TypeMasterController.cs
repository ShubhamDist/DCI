
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeMaster;
using DCI.Services.Abstractions.Master.TypeMaster;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.TypeMaster
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]    
    [ApiController]
    public class TypeMasterController : BaseController
    {
        private readonly ITypeMasterService _typeMasterService;
        public TypeMasterController(ITypeMasterService typeMasterService) => _typeMasterService = typeMasterService;

        #region TypeMaster                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All TypeMaster                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeMasterService.GetTypeMasterAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get TypeMaster by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        [NonAction]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeMasterService.GetTypeMasterByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add TypeMaster                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] TypeMasterEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeMasterService.SaveTypeMasterAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update TypeMaster                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] TypeMasterEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeMasterService.UpdateTypeMasterAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate TypeMaster                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeMasterService.DeleteTypeMasterAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
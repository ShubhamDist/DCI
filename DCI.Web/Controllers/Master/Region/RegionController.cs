
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Region;
using DCI.Services.Abstractions.Master.Region;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Region
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : BaseController
    {
        private readonly IRegionService _regionService;
        public RegionController(IRegionService regionService) => _regionService = regionService;

        #region Region                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Region                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _regionService.GetRegionAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Region by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _regionService.GetRegionByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Region                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] RegionEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _regionService.SaveRegionAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Region                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] RegionEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _regionService.UpdateRegionAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Region                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _regionService.DeleteRegionAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
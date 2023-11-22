
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Configuration;
using DCI.Services.Abstractions.Master.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Configuration
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : BaseController
    {
        private readonly IConfigurationService _configurationService;
        public ConfigurationController(IConfigurationService configurationService) => _configurationService = configurationService;

        #region Configuration                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Configuration                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _configurationService.GetConfigurationAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Configuration by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _configurationService.GetConfigurationByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Configuration                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] ConfigurationEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _configurationService.SaveConfigurationAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Configuration                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] ConfigurationEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _configurationService.UpdateConfigurationAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Configuration                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _configurationService.DeleteConfigurationAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
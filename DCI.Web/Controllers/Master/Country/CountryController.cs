
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Country;
using DCI.Services.Abstractions.Master.Country;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Country
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService) => _countryService = countryService;

        #region Country                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Country                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _countryService.GetCountryAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Country by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]      
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _countryService.GetCountryByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Country                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] CountryEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _countryService.SaveCountryAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Country                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] CountryEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _countryService.UpdateCountryAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Country                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _countryService.DeleteCountryAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
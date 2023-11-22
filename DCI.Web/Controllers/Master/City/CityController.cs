
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.City;
using DCI.Services.Abstractions.Master.City;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.City
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService) => _cityService = cityService;

        #region City                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All City                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.GetCityAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get City by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.GetCityByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        [HttpGet]
        [Route("GetByStateId")]      
        public async Task<IActionResult> GetCityByStateId(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.GetCityByStateIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add City                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] CityEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.SaveCityAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update City                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] CityEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.UpdateCityAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate City                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _cityService.DeleteCityAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
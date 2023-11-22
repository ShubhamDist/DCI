
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Station;
using DCI.Services.Abstractions.Master.Station;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Station
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : BaseController
    {
        private readonly IStationService _stationService;
        public StationController(IStationService stationService) => _stationService = stationService;

        #region Station                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Station                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.GetStationAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Station by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
       // [NonAction]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.GetStationByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStationByStateId")]
        public async Task<IActionResult> GetByStateId(int StateID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.GetStationByStateIdAsync(StateID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Station                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] StationEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.SaveStationAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Station                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] StationEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.UpdateStationAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Station                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _stationService.DeleteStationAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
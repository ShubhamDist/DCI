using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeDetail;
using DCI.Services.Abstractions.Master.TypeDetail;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.TypeDetail
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Master/[controller]")]
    [ApiController]
    public class TypeDetailController : BaseController
    {
        private readonly ITypeDetailService _typeDetailService;
        public TypeDetailController(ITypeDetailService typeDetailService) => _typeDetailService = typeDetailService;
    
        #region TypeDetail                                                                              
        /// <summary>                                                                                   
        /// Fetch All TypeDetails                                                                             
        /// </summary>                                                                                  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.GetTypeDetailAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   
        /// Get TypeDetail by ID                                                                        
        /// </summary>                                                                                  
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.GetTypeDetailByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [Route ("GetByParameter")]
        public async Task<IActionResult> GetByParameter([FromQuery] TypeDetailByTypeMasterReadOnlyEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.GetTypeDetailByMasterIdAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   
        /// To Add TypeDetail                                                                          
        /// </summary>                                                                                  
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TypeDetailEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.SaveTypeDetailAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   
        /// To Update TypeDetail                                                                      
        /// </summary>                                                                                  
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TypeDetailEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.UpdateTypeDetailAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   
        /// To Deactivate TypeDetail                                                                    
        /// </summary>                                                                                  

        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _typeDetailService.DeleteTypeDetailAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}

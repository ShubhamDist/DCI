
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Role;
using DCI.Services.Abstractions.Master.Role;
using Microsoft.AspNetCore.Mvc;

namespace DCI.Web.Controllers.Master.Role
{
    /// <summary>																										                	  
    /// 																												                	  
    /// </summary>																									                	  
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService) => _roleService = roleService;

        #region Role                                                                              					                      
        /// <summary>                                                                                   				                	  
        /// Fetch All Role                                                                             		                     	  
        /// </summary>                                                                                  				                	  
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _roleService.GetRoleAsync(cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// Get Role by ID                                                                        					                      
        /// </summary>                                                                                  				                	  
        [HttpGet("{ID}")]
        [NonAction]
        public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _roleService.GetRoleByIdAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   				                	  
        /// To Add Role                                                                          					                      
        /// </summary>                                                                                  				                	  
        [HttpPost]
        [NonAction]
        public async Task<IActionResult> Post([FromBody] RoleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _roleService.SaveRoleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Update Role                                                                      							    		  
        /// </summary>                                                                                  									  
        [HttpPut]
        [NonAction]
        public async Task<IActionResult> Put([FromBody] RoleEntity inputparameters, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _roleService.UpdateRoleAsync(inputparameters, cancellationToken);
            return await SendResponse(objResponse);
        }

        /// <summary>                                                                                   									  
        /// To Deactivate Role                                                                    								    	  
        /// </summary>                                                                                  									  

        [HttpDelete("{ID}")]
        [NonAction]
        public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)
        {
            ResponseModel objResponse = await _roleService.DeleteRoleAsync(ID, cancellationToken);
            return await SendResponse(objResponse);
        }
        #endregion
    }
}
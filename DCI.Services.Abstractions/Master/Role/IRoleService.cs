
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Role;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.Role		                                                                           
 {																                                                                           
     public interface IRoleService						                                                                               
     {														     	                                                                       
         #region Role                                                                                                                  
         Task<ResponseModel> GetRoleAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetRoleByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteRoleAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
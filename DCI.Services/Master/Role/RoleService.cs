
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Role;							                                                            
 using DCI.Domain.Repositories.Master.Role;						                                                            
 using DCI.Services.Abstractions.Master.Role;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Role								                                                            
 {																			                                                            
     public class RoleService : BaseService, IRoleService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IRoleRepository _roleRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public RoleService(IRoleRepository roleRepository) => _roleRepository = roleRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Role																			                                     
         public async Task<ResponseModel> GetRoleAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _roleRepository.GetRoleAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetRoleByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _roleRepository.GetRoleByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _roleRepository.SaveRoleAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _roleRepository.UpdateRoleAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteRoleAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _roleRepository.DeleteRoleAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
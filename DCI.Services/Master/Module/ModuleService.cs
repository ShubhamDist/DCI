
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Module;							                                                            
 using DCI.Domain.Repositories.Master.Module;						                                                            
 using DCI.Services.Abstractions.Master.Module;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Module								                                                            
 {																			                                                            
     public class ModuleService : BaseService, IModuleService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IModuleRepository _moduleRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public ModuleService(IModuleRepository moduleRepository) => _moduleRepository = moduleRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Module																			                                     
         public async Task<ResponseModel> GetModuleAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _moduleRepository.GetModuleAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _moduleRepository.GetModuleByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _moduleRepository.SaveModuleAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _moduleRepository.UpdateModuleAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteModuleAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _moduleRepository.DeleteModuleAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
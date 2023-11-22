
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.TypeMaster;							                                                            
 using DCI.Domain.Repositories.Master.TypeMaster;						                                                            
 using DCI.Services.Abstractions.Master.TypeMaster;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.TypeMaster								                                                            
 {																			                                                            
     public class TypeMasterService : BaseService, ITypeMasterService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly ITypeMasterRepository _typeMasterRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public TypeMasterService(ITypeMasterRepository typeMasterRepository) => _typeMasterRepository = typeMasterRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region TypeMaster																			                                     
         public async Task<ResponseModel> GetTypeMasterAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _typeMasterRepository.GetTypeMasterAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetTypeMasterByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _typeMasterRepository.GetTypeMasterByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _typeMasterRepository.SaveTypeMasterAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _typeMasterRepository.UpdateTypeMasterAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteTypeMasterAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _typeMasterRepository.DeleteTypeMasterAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
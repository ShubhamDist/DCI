
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.State;							                                                            
 using DCI.Domain.Repositories.Master.State;						                                                            
 using DCI.Services.Abstractions.Master.State;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.State								                                                            
 {																			                                                            
     public class StateService : BaseService, IStateService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IStateRepository _stateRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public StateService(IStateRepository stateRepository) => _stateRepository = stateRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region State																			                                     
         public async Task<ResponseModel> GetStateAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _stateRepository.GetStateAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetStateByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _stateRepository.GetStateByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveStateAsync(StateEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _stateRepository.SaveStateAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateStateAsync(StateEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _stateRepository.UpdateStateAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteStateAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _stateRepository.DeleteStateAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
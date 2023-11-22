
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Screen;							                                                            
 using DCI.Domain.Repositories.Master.Screen;						                                                            
 using DCI.Services.Abstractions.Master.Screen;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Screen								                                                            
 {																			                                                            
     public class ScreenService : BaseService, IScreenService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IScreenRepository _screenRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public ScreenService(IScreenRepository screenRepository) => _screenRepository = screenRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Screen																			                                     
         public async Task<ResponseModel> GetScreenAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _screenRepository.GetScreenAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetScreenByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _screenRepository.GetScreenByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _screenRepository.SaveScreenAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _screenRepository.UpdateScreenAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteScreenAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _screenRepository.DeleteScreenAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
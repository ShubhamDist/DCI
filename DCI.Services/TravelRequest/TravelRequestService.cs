
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.TravelRequest;							                                                            
 using DCI.Domain.Repositories.TravelRequest;						                                                            
 using DCI.Services.Abstractions.TravelRequest;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.TravelRequest								                                                            
 {																			                                                            
     public class TravelRequestService : BaseService, ITravelRequestService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly ITravelRequestRepository _travelRequestRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public TravelRequestService(ITravelRequestRepository travelRequestRepository) => _travelRequestRepository = travelRequestRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region TravelRequest																			                                     
         public async Task<ResponseModel> GetTravelRequestAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _travelRequestRepository.GetTravelRequestAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetTravelRequestByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _travelRequestRepository.GetTravelRequestByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _travelRequestRepository.SaveTravelRequestAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _travelRequestRepository.UpdateTravelRequestAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteTravelRequestAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _travelRequestRepository.DeleteTravelRequestAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
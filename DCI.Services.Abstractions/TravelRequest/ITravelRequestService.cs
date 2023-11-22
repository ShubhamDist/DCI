
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.TravelRequest;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.TravelRequest		                                                                           
 {																                                                                           
     public interface ITravelRequestService						                                                                               
     {														     	                                                                       
         #region TravelRequest                                                                                                                  
         Task<ResponseModel> GetTravelRequestAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetTravelRequestByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteTravelRequestAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
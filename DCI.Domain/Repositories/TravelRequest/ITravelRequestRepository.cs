
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.TravelRequest;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.TravelRequest  	                                                                               
 {														                                                                                   
     public interface ITravelRequestRepository			                                                                                       
     {													                                                                                   
         #region TravelRequest                                                                                                                  
         Task<IEnumerable<TravelRequestReadOnlyEntity>> GetTravelRequestAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<TravelRequestReadOnlyEntity>> GetTravelRequestByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteTravelRequestAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
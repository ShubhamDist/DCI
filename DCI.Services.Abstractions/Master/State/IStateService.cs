
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.State;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.State		                                                                           
 {																                                                                           
     public interface IStateService						                                                                               
     {														     	                                                                       
         #region State                                                                                                                  
         Task<ResponseModel> GetStateAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetStateByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveStateAsync(StateEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateStateAsync(StateEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteStateAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
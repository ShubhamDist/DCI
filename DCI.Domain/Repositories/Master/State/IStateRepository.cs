
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.State;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.State  	                                                                               
 {														                                                                                   
     public interface IStateRepository			                                                                                       
     {													                                                                                   
         #region State                                                                                                                  
         Task<IEnumerable<StateReadOnlyEntity>> GetStateAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<StateReadOnlyEntity>> GetStateByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveStateAsync(StateEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateStateAsync(StateEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteStateAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
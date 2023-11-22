
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Screen;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Screen  	                                                                               
 {														                                                                                   
     public interface IScreenRepository			                                                                                       
     {													                                                                                   
         #region Screen                                                                                                                  
         Task<IEnumerable<ScreenReadOnlyEntity>> GetScreenAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<ScreenReadOnlyEntity>> GetScreenByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteScreenAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
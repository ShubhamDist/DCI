
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Module;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Module  	                                                                               
 {														                                                                                   
     public interface IModuleRepository			                                                                                       
     {													                                                                                   
         #region Module                                                                                                                  
         Task<IEnumerable<ModuleReadOnlyEntity>> GetModuleAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<ModuleReadOnlyEntity>> GetModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteModuleAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
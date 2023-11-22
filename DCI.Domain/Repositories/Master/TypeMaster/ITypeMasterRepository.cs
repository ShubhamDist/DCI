
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.TypeMaster;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.TypeMaster  	                                                                               
 {														                                                                                   
     public interface ITypeMasterRepository			                                                                                       
     {													                                                                                   
         #region TypeMaster                                                                                                                  
         Task<IEnumerable<TypeMasterReadOnlyEntity>> GetTypeMasterAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<TypeMasterReadOnlyEntity>> GetTypeMasterByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteTypeMasterAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               

 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Role;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Role  	                                                                               
 {														                                                                                   
     public interface IRoleRepository			                                                                                       
     {													                                                                                   
         #region Role                                                                                                                  
         Task<IEnumerable<RoleReadOnlyEntity>> GetRoleAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<RoleReadOnlyEntity>> GetRoleByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteRoleAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               

 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Region;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Region  	                                                                               
 {														                                                                                   
     public interface IRegionRepository			                                                                                       
     {													                                                                                   
         #region Region                                                                                                                  
         Task<IEnumerable<RegionReadOnlyEntity>> GetRegionAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<RegionReadOnlyEntity>> GetRegionByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteRegionAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
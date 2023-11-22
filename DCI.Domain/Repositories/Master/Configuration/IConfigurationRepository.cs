
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Configuration;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Configuration  	                                                                               
 {														                                                                                   
     public interface IConfigurationRepository			                                                                                       
     {													                                                                                   
         #region Configuration                                                                                                                  
         Task<IEnumerable<ConfigurationReadOnlyEntity>> GetConfigurationAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<ConfigurationReadOnlyEntity>> GetConfigurationByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteConfigurationAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
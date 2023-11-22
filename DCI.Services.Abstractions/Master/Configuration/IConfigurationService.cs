
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Configuration;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.Configuration		                                                                           
 {																                                                                           
     public interface IConfigurationService						                                                                               
     {														     	                                                                       
         #region Configuration                                                                                                                  
         Task<ResponseModel> GetConfigurationAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetConfigurationByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteConfigurationAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
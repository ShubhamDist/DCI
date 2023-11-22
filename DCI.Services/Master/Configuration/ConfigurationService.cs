
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Configuration;							                                                            
 using DCI.Domain.Repositories.Master.Configuration;						                                                            
 using DCI.Services.Abstractions.Master.Configuration;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Configuration								                                                            
 {																			                                                            
     public class ConfigurationService : BaseService, IConfigurationService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IConfigurationRepository _configurationRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public ConfigurationService(IConfigurationRepository configurationRepository) => _configurationRepository = configurationRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Configuration																			                                     
         public async Task<ResponseModel> GetConfigurationAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _configurationRepository.GetConfigurationAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetConfigurationByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _configurationRepository.GetConfigurationByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _configurationRepository.SaveConfigurationAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _configurationRepository.UpdateConfigurationAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteConfigurationAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _configurationRepository.DeleteConfigurationAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
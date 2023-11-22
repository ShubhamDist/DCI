
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Country;							                                                            
 using DCI.Domain.Repositories.Master.Country;						                                                            
 using DCI.Services.Abstractions.Master.Country;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Country								                                                            
 {																			                                                            
     public class CountryService : BaseService, ICountryService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly ICountryRepository _countryRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public CountryService(ICountryRepository countryRepository) => _countryRepository = countryRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Country																			                                     
         public async Task<ResponseModel> GetCountryAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _countryRepository.GetCountryAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetCountryByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _countryRepository.GetCountryByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _countryRepository.SaveCountryAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _countryRepository.UpdateCountryAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteCountryAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _countryRepository.DeleteCountryAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
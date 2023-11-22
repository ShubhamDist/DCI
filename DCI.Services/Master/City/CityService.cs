
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.City;							                                                            
 using DCI.Domain.Repositories.Master.City;						                                                            
 using DCI.Services.Abstractions.Master.City;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.City								                                                            
 {																			                                                            
     public class CityService : BaseService, ICityService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly ICityRepository _cityRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public CityService(ICityRepository cityRepository) => _cityRepository = cityRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region City																			                                     
         public async Task<ResponseModel> GetCityAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _cityRepository.GetCityAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetCityByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _cityRepository.GetCityByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }
        public async Task<ResponseModel> GetCityByStateIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _cityRepository.GetCityByStateIdAsync(inputparameters, cancellationToken);
            return await ReadResponse(obj);
        }
        public async Task<ResponseModel> SaveCityAsync(CityEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _cityRepository.SaveCityAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateCityAsync(CityEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _cityRepository.UpdateCityAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteCityAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _cityRepository.DeleteCityAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
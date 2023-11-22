
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Station;							                                                            
 using DCI.Domain.Repositories.Master.Station;						                                                            
 using DCI.Services.Abstractions.Master.Station;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Station								                                                            
 {																			                                                            
     public class StationService : BaseService, IStationService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IStationRepository _stationRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public StationService(IStationRepository stationRepository) => _stationRepository = stationRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Station																			                                     
         public async Task<ResponseModel> GetStationAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _stationRepository.GetStationAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetStationByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _stationRepository.GetStationByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }
        public async Task<ResponseModel> GetStationByStateIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _stationRepository.GetStationByStateIdAsync(inputparameters, cancellationToken);
            return await ReadResponse(obj);
        }
        public async Task<ResponseModel> SaveStationAsync(StationEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _stationRepository.SaveStationAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateStationAsync(StationEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _stationRepository.UpdateStationAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteStationAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _stationRepository.DeleteStationAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
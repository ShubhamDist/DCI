
 using DCI.Domain.Entities.Base;                                                                                                      
 using DCI.Domain.Entities.Master.Region;							                                                            
 using DCI.Domain.Repositories.Master.Region;						                                                            
 using DCI.Services.Abstractions.Master.Region;						                                                            
 using DCI.Services.Base;													                                                            
 using DCI.Utility;														                                                            
 																			                                                            
 namespace DCI.Services.Master.Region								                                                            
 {																			                                                            
     public class RegionService : BaseService, IRegionService		                                                                
     {																		                                                            
         #region variables													                                                            
         private readonly IRegionRepository _regionRepository;		                                                            
         ResponseModel blank_result = new ResponseModel();					                                                            
         #endregion														                                                            
 																			                                                            
         #region Constructor												                                                            
         public RegionService(IRegionRepository regionRepository) => _regionRepository = regionRepository;               
         #endregion                                                                                                                     
 																									                                     
         #region Region																			                                     
         public async Task<ResponseModel> GetRegionAsync(CancellationToken cancellationToken)	                                         
         {																							                                     
             var obj = await _regionRepository.GetRegionAsync(cancellationToken);			                                         
             return await ReadResponse(obj);														                                     
         }																							                                     
         public async Task<ResponseModel> GetRegionByIdAsync(int inputparameters, CancellationToken cancellationToken)                 
         {		 var obj = await _regionRepository.GetRegionByIdAsync(inputparameters, cancellationToken);			                 
             return await ReadResponse(obj);																     						 
         }																			                                                     
         public async Task<ResponseModel> SaveRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken)          
         {																															     
             DBResponseEntity obj = await _regionRepository.SaveRegionAsync(inputparameters, cancellationToken);			         
             return await Response(obj, Enums.Insert.ToString());																	     
         }																															     
         public async Task<ResponseModel> UpdateRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken)        
         {																															     
             DBResponseEntity obj = await _regionRepository.UpdateRegionAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Update.ToString());																	     
         }																															     
         public async Task<ResponseModel> DeleteRegionAsync(int inputparameters, CancellationToken cancellationToken)		    	     
         {																															     
             DBResponseEntity obj = await _regionRepository.DeleteRegionAsync(inputparameters, cancellationToken);			     
             return await Response(obj, Enums.Delete.ToString());		                                                                 
         }																                                                                 
         #endregion													                                                                 
     }																	                                                                 
 }																		                                                                 
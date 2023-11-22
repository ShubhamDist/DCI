
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Region;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.Region		                                                                           
 {																                                                                           
     public interface IRegionService						                                                                               
     {														     	                                                                       
         #region Region                                                                                                                  
         Task<ResponseModel> GetRegionAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetRegionByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteRegionAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
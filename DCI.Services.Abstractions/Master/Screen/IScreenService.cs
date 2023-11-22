
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Screen;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.Screen		                                                                           
 {																                                                                           
     public interface IScreenService						                                                                               
     {														     	                                                                       
         #region Screen                                                                                                                  
         Task<ResponseModel> GetScreenAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetScreenByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteScreenAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
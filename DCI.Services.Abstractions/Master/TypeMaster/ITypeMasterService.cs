
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.TypeMaster;					                                                                       
 																                                                                           
 namespace DCI.Services.Abstractions.Master.TypeMaster		                                                                           
 {																                                                                           
     public interface ITypeMasterService						                                                                               
     {														     	                                                                       
         #region TypeMaster                                                                                                                  
         Task<ResponseModel> GetTypeMasterAsync(CancellationToken cancellationToken);                                                        
         Task<ResponseModel> GetTypeMasterByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       
         Task<ResponseModel> SaveTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken);	                       
         Task<ResponseModel> UpdateTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken);  	                   
         Task<ResponseModel> DeleteTypeMasterAsync(int inputparameters, CancellationToken cancellationToken);				                   
         #endregion                                                                                                                       
     }															                                                                           
 }																                                                                           
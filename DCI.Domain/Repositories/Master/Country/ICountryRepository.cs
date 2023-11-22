
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Country;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Country  	                                                                               
 {														                                                                                   
     public interface ICountryRepository			                                                                                       
     {													                                                                                   
         #region Country                                                                                                                  
         Task<IEnumerable<CountryReadOnlyEntity>> GetCountryAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<CountryReadOnlyEntity>> GetCountryByIdAsync(int inputparameters, CancellationToken cancellationToken);	       
         Task<DBResponseEntity> SaveCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteCountryAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
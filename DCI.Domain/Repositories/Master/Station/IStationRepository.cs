
 using DCI.Domain.Entities.Base;                                                                                                         
 using DCI.Domain.Entities.Master.Station;			                                                                               
 														                                                                                   
 namespace DCI.Domain.Repositories.Master.Station  	                                                                               
 {														                                                                                   
     public interface IStationRepository			                                                                                       
     {													                                                                                   
         #region Station                                                                                                                  
         Task<IEnumerable<StationReadOnlyEntity>> GetStationAsync(CancellationToken cancellationToken);                                   
         Task<IEnumerable<StationReadOnlyEntity>> GetStationByIdAsync(int inputparameters, CancellationToken cancellationToken);
         Task<IEnumerable<StationReadOnlyEntity>> GetStationByStateIdAsync(int inputparameters, CancellationToken cancellationToken);
         Task<DBResponseEntity> SaveStationAsync(StationEntity inputparameters, CancellationToken cancellationToken);					   
         Task<DBResponseEntity> UpdateStationAsync(StationEntity inputparameters, CancellationToken cancellationToken);				   
         Task<DBResponseEntity> DeleteStationAsync(int inputparameters, CancellationToken cancellationToken);						   	   
         #endregion                                                                                                                       
     }														                                                                               
 }															                                                                               
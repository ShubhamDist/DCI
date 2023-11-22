
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Station;

namespace DCI.Services.Abstractions.Master.Station
{
    public interface IStationService
    {
        #region Station                                                                                                                  
        Task<ResponseModel> GetStationAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetStationByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> GetStationByStateIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveStationAsync(StationEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateStationAsync(StationEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteStationAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}
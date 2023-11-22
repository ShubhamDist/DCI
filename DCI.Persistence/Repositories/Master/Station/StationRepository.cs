
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Station;
using DCI.Domain.Repositories.Master.Station;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Constants;

namespace DCI.Persistence.Repositories.Master.Station
{
    public class StationRepository : GenericRepository, IStationRepository
    {
        #region Variables																                                                                	 
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor															                                                                	 
        public StationRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Station																                                                                	 
        public async Task<IEnumerable<StationReadOnlyEntity>> GetStationAsync(CancellationToken cancellationToken)
        {
            return await Get<StationReadOnlyEntity>(RepositoryConstants.GETSTATION);
        }
        public async Task<IEnumerable<StationReadOnlyEntity>> GetStationByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, StationReadOnlyEntity>(inputparameters, RepositoryConstants.GETSTATIONBYID);
        }
        public async Task<IEnumerable<StationReadOnlyEntity>> GetStationByStateIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, StationReadOnlyEntity>(inputparameters, RepositoryConstants.GETSTATIONBYSTATEID);
        }
        public async Task<DBResponseEntity> SaveStationAsync(StationEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Insert<StationEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDSTATION);
        }
        public async Task<DBResponseEntity> UpdateStationAsync(StationEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Update<StationEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATESTATION);
        }
        public async Task<DBResponseEntity> DeleteStationAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETESTATION);
        }
        #endregion
    }
}
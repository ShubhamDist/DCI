
using Dapper;
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.TravelRequest;
using DCI.Domain.Repositories.TravelRequest;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Constants;
using Npgsql.Internal;

namespace DCI.Persistence.Repositories.TravelRequest
{
    public class TravelRequestRepository : GenericRepository, ITravelRequestRepository
    {
        #region Variables																                                                                	 
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor															                                                                	 
        public TravelRequestRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region TravelRequest																                                                                	 
        public async Task<IEnumerable<TravelRequestReadOnlyEntity>> GetTravelRequestAsync(CancellationToken cancellationToken)
        {
            return await Get<TravelRequestReadOnlyEntity>(RepositoryConstants.GETTRAVELREQUEST);
        }
        public async Task<IEnumerable<TravelRequestReadOnlyEntity>> GetTravelRequestByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, TravelRequestReadOnlyEntity>(inputparameters, RepositoryConstants.GETTRAVELREQUESTBYID);
        }
        public async Task<DBResponseEntity> SaveTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = new DBResponseEntity();
            obj.ErrorMessage = InsertTravelRequest(inputparameters, RepositoryConstants.ADDTRAVELREQUEST).Result;
            return obj;
        }
        public async Task<DBResponseEntity> UpdateTravelRequestAsync(TravelRequestFormEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Update<TravelRequestFormEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATETRAVELREQUEST);
        }
        public async Task<DBResponseEntity> DeleteTravelRequestAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETETRAVELREQUEST);
        }
        #endregion
    }
}
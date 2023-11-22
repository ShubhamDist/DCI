using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.SubModule;
using DCI.Domain.Repositories.Master.SubModule;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Constants;

namespace DCI.Persistence.Repositories.Master.SubModule
{
    public class SubModuleRepository : GenericRepository, ISubModuleRepository
    {
        #region Variables																                                                                	 
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor															                                                                	 
        public SubModuleRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region SubModule																                                                                	 
        public async Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleAsync(CancellationToken cancellationToken)
        {
            return await Get<SubModuleReadOnlyEntity>(RepositoryConstants.GETSUBMODULE);
        }
        public async Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, SubModuleReadOnlyEntity>(inputparameters, RepositoryConstants.GETSUBMODULEBYID);
        }
        public async Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleByModuleIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, SubModuleReadOnlyEntity>(inputparameters, RepositoryConstants.GETSUBMODULEBYMODULEID);
        }
        public async Task<DBResponseEntity> SaveSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Insert<SubModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDSUBMODULE);
        }
        public async Task<DBResponseEntity> UpdateSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Update<SubModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATESUBMODULE);
        }
        public async Task<DBResponseEntity> DeleteSubModuleAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETESUBMODULE);
        }
        #endregion
    }
}
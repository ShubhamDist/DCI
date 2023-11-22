using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Module;
using DCI.Domain.Repositories.Master.Module;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Constants;

namespace DCI.Persistence.Repositories.Master.Module
{
    public class ModuleRepository : GenericRepository, IModuleRepository
    {
        #region Variables																                                                                	 
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor															                                                                	 
        public ModuleRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Module																                                                                	 
        public async Task<IEnumerable<ModuleReadOnlyEntity>> GetModuleAsync(CancellationToken cancellationToken)
        {
            return await Get<ModuleReadOnlyEntity>(RepositoryConstants.GETMODULE);
        }
        public async Task<IEnumerable<ModuleReadOnlyEntity>> GetModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, ModuleReadOnlyEntity>(inputparameters, RepositoryConstants.GETMODULEBYID);
        }
        public async Task<DBResponseEntity> SaveModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Insert<ModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDMODULE);
        }
        public async Task<DBResponseEntity> UpdateModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Update<ModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATEMODULE);
        }
        public async Task<DBResponseEntity> DeleteModuleAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETEMODULE);
        }
        #endregion
    }
}
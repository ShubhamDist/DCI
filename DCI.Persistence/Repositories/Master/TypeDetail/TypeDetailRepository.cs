using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeDetail;
using DCI.Domain.Repositories.Master.TypeDetail;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Constants;

namespace DCI.Persistence.Repositories.Master.TypeDetail
{
    public class TypeDetailRepository : GenericRepository, ITypeDetailRepository
    {
        #region Variables
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor
        public TypeDetailRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Functions
        public async Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailAsync(CancellationToken cancellationToken)
        {
            return await Get<TypeDetailReadOnlyEntity>(RepositoryConstants.GETTYPEDETAIL);
        }
        public async Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, TypeDetailReadOnlyEntity>(inputparameters, RepositoryConstants.GETTYPEDETAILBYID);
        }
        public async Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailByMasterIdAsync(TypeDetailByTypeMasterReadOnlyEntity inputparameters, CancellationToken cancellationToken)
        {
            return await GetByParam<TypeDetailByTypeMasterReadOnlyEntity, TypeDetailReadOnlyEntity>(inputparameters, RepositoryConstants.GETTYPEDETAILBYTYPEMASTERID);
        }
        public async Task<DBResponseEntity> SaveTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Insert<TypeDetailEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDTYPEDETAIL);
        }
        public async Task<DBResponseEntity> UpdateTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken)
        {
            return await Update<TypeDetailEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATETYPEDETAIL);
        }
        public async Task<DBResponseEntity> DeleteTypeDetailAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETETYPEDETAIL);
        }
        #endregion
    }
}

using Dapper;
using DCI.Domain.Entities.TravelRequest;
using DCI.Domain.Repositories.Base;
using DCI.Utility;
using System.Data;
using static Dapper.SqlMapper;

namespace DCI.Persistence.Repositories.BaseRepository
{
    public class GenericRepository : IGenericRepository
    {
        #region Variables
        private readonly RepositoryDbContext _dbContext;
        #endregion

        #region Constructor
        public GenericRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        #endregion

        #region Functions
        public async Task<IEnumerable<T>> Get<T>(string FunctionName)
        {
            string fun_query = InputParameter.GetQuery(FunctionName);
            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T>(fun_query, null, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result;
            }
        }
        public async Task<IEnumerable<T1>> GetById<T, T1>(T entity, string FunctionName)
        {
            string fun_query = InputParameter.GetQueryByID(FunctionName, entity);
            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T1>(fun_query, null, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result;
            }
        }
        public async Task<IEnumerable<T1>> GetByParam<T, T1>(T entity, string FunctionName)
        {
            DynamicParameters proc_parameters = InputParameter.GetParameters(entity);
            //string fun_query = InputParameter.GetQueryByID(FunctionName, entity);
            //string fun_query = InputParameter.GetQueryWithParameters(FunctionName, entity);
            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T1>(FunctionName, proc_parameters, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result;
            }
        }
        public async Task<T1> Insert<T, T1>(T entity, string FunctionName)
        {
            DynamicParameters proc_parameters = InputParameter.BindParametersList(entity);

            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T1>(FunctionName, proc_parameters, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result.FirstOrDefault();
            }
        }

        public async Task<string> InsertTravelRequest(TravelRequestFormEntity entity, string FunctionName)
        {
            DynamicParameters proc_parameters = new DynamicParameters();
            var travelrequesttraveldetail = Conversion.ListtoDataTableConverter(entity.TravelRequestTravelDetail);
            var travelrequestaccommodation = Conversion.ListtoDataTableConverter(entity.TravelRequestAccommodation);
            var travelrequestvehiclerequest = Conversion.ListtoDataTableConverter(entity.TravelRequestVehicleRequest);

            proc_parameters.AddDynamicParams(InputParameter.GetParameters(entity.TravelRequest));
            proc_parameters.Add("@TravelRequestTravelDetail", travelrequesttraveldetail, DbType.Object);
            proc_parameters.Add("@TravelRequestVehicleRequest", travelrequestvehiclerequest.AsTableValuedParameter(), DbType.Object);
            proc_parameters.Add("@TravelRequestAccommodation", travelrequestaccommodation.AsTableValuedParameter(), DbType.Object);

            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<string>(FunctionName, proc_parameters, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.StoredProcedure);
                return "";
            }
        }
        public async Task<T1> Update<T, T1>(T entity, string FunctionName)
        {
            DynamicParameters proc_parameters = InputParameter.GetParameters(entity);
            string fun_query = InputParameter.GetQueryWithParameters(FunctionName, entity);
            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T1>(fun_query, proc_parameters, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result.FirstOrDefault();
            }
        }
        public async Task<T1> Delete<T, T1>(T entity, string FunctionName)
        {
            string fun_query = InputParameter.GetQueryByID(FunctionName, entity);
            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.QueryAsync<T1>(fun_query, null, null, DCI.Utility.Constants.TIMEOUT, System.Data.CommandType.Text);
                return result.FirstOrDefault();
            }
        }
        #endregion
    }
}

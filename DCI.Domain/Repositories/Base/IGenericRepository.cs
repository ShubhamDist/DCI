namespace DCI.Domain.Repositories.Base
{
    public interface IGenericRepository
    {
        Task<IEnumerable<T>> Get<T>(string FunctionName);
        Task<IEnumerable<T1>> GetById<T, T1>(T entity, string FunctionName);
        Task<T1> Insert<T, T1>(T entity, string FunctionName);
        Task<T1> Update<T, T1>(T entity, string FunctionName);
        Task<T1> Delete<T, T1>(T entity, string FunctionName);
    }
}

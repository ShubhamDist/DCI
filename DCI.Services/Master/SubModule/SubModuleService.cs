using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.SubModule;
using DCI.Domain.Repositories.Master.SubModule;
using DCI.Services.Abstractions.Master.SubModule;
using DCI.Services.Base;
using DCI.Utility;

namespace DCI.Services.Master.SubModule
{
    public class SubModuleService : BaseService, ISubModuleService
    {
        #region variables													                                                            
        private readonly ISubModuleRepository _subModuleRepository;
        ResponseModel blank_result = new ResponseModel();
        #endregion

        #region Constructor												                                                            
        public SubModuleService(ISubModuleRepository subModuleRepository) => _subModuleRepository = subModuleRepository;
        #endregion

        #region SubModule																			                                     
        public async Task<ResponseModel> GetSubModuleAsync(CancellationToken cancellationToken)
        {
            var obj = await _subModuleRepository.GetSubModuleAsync(cancellationToken);
            return await ReadResponse(obj);
        }
        public async Task<ResponseModel> GetSubModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _subModuleRepository.GetSubModuleByIdAsync(inputparameters, cancellationToken);
            return await ReadResponse(obj);
        }

        public async Task<ResponseModel> GetSubModuleByModuleIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _subModuleRepository.GetSubModuleByModuleIdAsync(inputparameters, cancellationToken);
            return await ReadResponse(obj);
        }
        public async Task<ResponseModel> SaveSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _subModuleRepository.SaveSubModuleAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Insert.ToString());
        }
        public async Task<ResponseModel> UpdateSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _subModuleRepository.UpdateSubModuleAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Update.ToString());
        }
        public async Task<ResponseModel> DeleteSubModuleAsync(int inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _subModuleRepository.DeleteSubModuleAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Delete.ToString());
        }
        #endregion
    }
}
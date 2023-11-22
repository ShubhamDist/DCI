using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeDetail;
using DCI.Domain.Repositories.Master.TypeDetail;
using DCI.Services.Abstractions.Master.TypeDetail;
using DCI.Services.Base;
using DCI.Utility;

namespace DCI.Services.Master.TypeDetail
{
    public class TypeDetailService : BaseService, ITypeDetailService
    {
        #region variables
        private readonly ITypeDetailRepository _typeDetailRepository;
        ResponseModel blank_result = new ResponseModel();
        #endregion

        #region Constructor
        public TypeDetailService(ITypeDetailRepository typeDetailRepository) => _typeDetailRepository = typeDetailRepository;
        #endregion

        #region Functions
        public async Task<ResponseModel> GetTypeDetailAsync(CancellationToken cancellationToken)
        {
            var obj = await _typeDetailRepository.GetTypeDetailAsync(cancellationToken);
            return await ReadResponse(obj);
        }
        public async Task<ResponseModel> GetTypeDetailByIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _typeDetailRepository.GetTypeDetailByIdAsync(inputparameters, cancellationToken);

            // Returning Json response with individual tymasterid as key to fetch typedetail list
            TypeMsterResponseEntity objtypemasterresponse = new TypeMsterResponseEntity();
            var dictionaryresponse = new Dictionary<string, TypeMsterResponseEntity>();
            var groupedlist = obj.GroupBy(b => b.TypeMasterId).Select(a => new
            {
                typemasterid = a.Key,
                tymastername = a.Select(t => t.TypeMasterName).ToList().FirstOrDefault(),
                logicalcode = a.Select(t => t.TypeMasterLogicalCode).ToList().FirstOrDefault(),
            }).ToList();


            foreach (var item in groupedlist)
            {
                // var typemasterlist = new List<GetTypeMsterList>();
                var objtypedetailresponse = new List<TypeDetailResponseEntity>();
                var typeDetailList = obj.ToList().Where(a => a.TypeMasterId == item.typemasterid).Select(g => new
                {
                    g.TypeDetailId,
                    g.TypeDetailName,
                }).ToList();
                foreach (var item1 in typeDetailList)
                {
                    objtypedetailresponse.Add(new TypeDetailResponseEntity()
                    {
                        TypeDetailId = item1.TypeDetailId,
                        TypeDetailName = item1.TypeDetailName,
                    });
                }

                objtypemasterresponse = new TypeMsterResponseEntity
                {
                    TypeMasterId = item.typemasterid,
                    TypeMasterName = item.tymastername,
                    typeDetailResponseEntity = objtypedetailresponse,

                };
                dictionaryresponse.Add(item.logicalcode, objtypemasterresponse);
            }

            return await ReadDictionary(dictionaryresponse);
        }
        public async Task<ResponseModel> GetTypeDetailByMasterIdAsync(TypeDetailByTypeMasterReadOnlyEntity inputparameters, CancellationToken cancellationToken)
        {
            var obj = await _typeDetailRepository.GetTypeDetailByMasterIdAsync(inputparameters, cancellationToken);
            // Returning Json response with individual tymasterid as key to fetch typedetail list
            TypeMsterResponseEntity objtypemasterresponse = new TypeMsterResponseEntity();
            var dictionaryresponse = new Dictionary<string, TypeMsterResponseEntity>();
            var groupedlist = obj.GroupBy(b => b.TypeMasterId).Select(a => new
            {
                typemasterid = a.Key,
                tymastername = a.Select(t => t.TypeMasterName).ToList().FirstOrDefault(),
                logicalcode = a.Select(t => t.TypeMasterLogicalCode).ToList().FirstOrDefault(),
            }).ToList();


            foreach (var item in groupedlist)
            {
                // var typemasterlist = new List<GetTypeMsterList>();
                var objtypedetailresponse = new List<TypeDetailResponseEntity>();
                var typeDetailList = obj.ToList().Where(a => a.TypeMasterId == item.typemasterid).Select(g => new
                {
                    g.TypeDetailId,
                    g.TypeDetailName,
                }).ToList();
                foreach (var item1 in typeDetailList)
                {
                    objtypedetailresponse.Add(new TypeDetailResponseEntity()
                    {
                        TypeDetailId = item1.TypeDetailId,
                        TypeDetailName = item1.TypeDetailName,
                    });
                }

                objtypemasterresponse = new TypeMsterResponseEntity
                {
                    TypeMasterId = item.typemasterid,
                    TypeMasterName = item.tymastername,
                    typeDetailResponseEntity = objtypedetailresponse,

                };
                dictionaryresponse.Add(item.logicalcode, objtypemasterresponse);
            }

            return await ReadDictionary(dictionaryresponse);

        }
        public async Task<ResponseModel> SaveTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _typeDetailRepository.SaveTypeDetailAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Insert.ToString());
        }
        public async Task<ResponseModel> UpdateTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _typeDetailRepository.UpdateTypeDetailAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Update.ToString());
        }
        public async Task<ResponseModel> DeleteTypeDetailAsync(int inputparameters, CancellationToken cancellationToken)
        {
            DBResponseEntity obj = await _typeDetailRepository.DeleteTypeDetailAsync(inputparameters, cancellationToken);
            return await Response(obj, Enums.Delete.ToString());
        }
        #endregion
    }
}

using DCI.Domain.Entities.Base;
using DCI.Utility;

namespace DCI.Services.Base
{
    public class BaseService
    {
        public BaseService() { }
        ResponseModel blank_result = new ResponseModel();

        public async Task<ResponseModel> ReadResponse(IEnumerable<object> result)
        {
            return result != null && result.Count() != 0 ?
                blank_result = GenerateOutput(result, "", 0, 0) :
                blank_result = ErrorGenerateOutput(null, Constants.NORECORDSFOUND, 0, 0);
        }
        public async Task<ResponseModel> ReadDictionary(object result)
        {
            return result != null ?
                blank_result = GenerateOutput(result, "", 0, 0) :
                blank_result = ErrorGenerateOutput(null, Constants.NORECORDSFOUND, 0, 0);
        }
        public async Task<ResponseModel> Response(DBResponseEntity result, string Event)
        {
            Enums operation = Enum.Parse<Enums>(Event);
            switch (operation)
            {
                case Enums.Insert:
                    {
                        return result != null ?
                         blank_result = GenerateOutput(result, Constants.ADDSUCCESS, 0, 0) :
                         blank_result = ErrorGenerateOutput(null, Constants.ADDFAILED, 0, 0);
                    }

                case Enums.Update:
                    {
                        return result != null ?
                         blank_result = GenerateOutput(result, Constants.UPDATESUCCESS, 0, 0) :
                         blank_result = ErrorGenerateOutput(null, Constants.UPDATEFAILED, 0, 0);
                    }

                case Enums.Delete:
                    {
                        return result != null ?
                         blank_result = GenerateOutput(result, Constants.DELETESUCCESS, 0, 0) :
                         blank_result = ErrorGenerateOutput(null, Constants.DELETEFAILED, 0, 0);
                    }

            }
            return blank_result;
        }
        private static ResponseModel GenerateOutput(object? response, string? message, int? totalRecords, int? totalDisplayRecords)
        {
            ResponseModel output = new()
            {
                Data = response,
                Result = true,
                Message = message,
                ResponseCode = 200,
                Severity = string.Empty,
                TotalRecords = totalRecords,
                TotalDisplayRecords = totalDisplayRecords,
                InnerException = null,
                StackTrace = string.Empty
            };
            return output;
        }
        private static ResponseModel ErrorGenerateOutput(object? response, string? message, int? totalRecords, int? totalDisplayRecords)
        {
            ResponseModel output = new()
            {
                Data = response,
                Result = false,
                Message = message,
                ResponseCode = 200,
                Severity = string.Empty,
                TotalRecords = totalRecords,
                TotalDisplayRecords = totalDisplayRecords,
                InnerException = null,
                StackTrace = string.Empty
            };

            return output;
        }

    }
}

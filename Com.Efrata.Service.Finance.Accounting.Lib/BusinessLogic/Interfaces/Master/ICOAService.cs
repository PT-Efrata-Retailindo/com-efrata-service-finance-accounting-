using Com.Efrata.Service.Finance.Accounting.Lib.Models.MasterCOA;
using Com.Efrata.Service.Finance.Accounting.Lib.Services.BasicUploadCsvService;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.MasterCOA;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.Master
{
    public interface ICOAService : IBaseService<COAModel>, IBasicUploadCsvService<COAViewModel>
    {
        Task UploadData(List<COAModel> data);
        MemoryStream DownloadTemplate();
        List<COAModel> GetAll();
        Task<List<COAModel>> GetEmptyNames();
        Task<int> ReviseEmptyNamesCoa(List<COAModel> data);
    }
}

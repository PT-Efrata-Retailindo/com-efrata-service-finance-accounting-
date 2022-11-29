using Com.Efrata.Service.Finance.Accounting.Lib.Models.LockTransaction;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.LockTransaction
{
    public interface ILockTransactionService : IBaseService<LockTransactionModel>
    {
        Task<LockTransactionModel> GetLastActiveLockTransaction(string type);
    }
}

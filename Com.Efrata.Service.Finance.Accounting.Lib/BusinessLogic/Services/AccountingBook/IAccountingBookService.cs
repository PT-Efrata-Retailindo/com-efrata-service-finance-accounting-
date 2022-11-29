using Com.Efrata.Service.Finance.Accounting.Lib.Models.AccountingBook;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Services.AccountingBook
{
    public interface IAccountingBookService 
    {
        ReadResponse<AccountingBookModel> Read(int page, int size, string order, List<string> select, string keyword, string filter);
        Task<int> CreateAsync(AccountingBookModel model);
        Task<AccountingBookModel> ReadByIdAsync(int id);        
        Task<int> UpdateAsync(int id, AccountingBookModel model);
        Task<int> DeleteAsync(int id);
    }
}

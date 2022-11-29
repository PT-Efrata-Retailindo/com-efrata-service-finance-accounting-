using AutoMapper;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.LockTransaction;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.LockTransaction;

namespace Com.Efrata.Service.Finance.Accounting.Lib.AutoMapperProfiles.LockTransaction
{
    public class LockTransactionProfile : Profile
    {
        public LockTransactionProfile()
        {
            CreateMap<LockTransactionModel, LockTransactionViewModel>()
                .ReverseMap();
        }
    }
}

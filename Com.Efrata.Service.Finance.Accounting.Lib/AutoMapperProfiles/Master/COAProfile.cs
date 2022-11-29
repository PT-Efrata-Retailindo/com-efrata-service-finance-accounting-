using AutoMapper;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.MasterCOA;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.MasterCOA;

namespace Com.Efrata.Service.Finance.Accounting.Lib.AutoMapperProfiles.Master
{
    public class COAProfile : Profile
    {
        public COAProfile()
        {
            CreateMap<COAModel, COAViewModel>().ReverseMap();
        }
    }
}

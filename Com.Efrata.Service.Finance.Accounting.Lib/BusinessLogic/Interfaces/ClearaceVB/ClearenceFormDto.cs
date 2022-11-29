using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System.Collections.Generic;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.ClearaceVB
{
    public class ClearenceFormDto
    {
        public List<ClearencePostId> ListIds { get; set; }
        public AccountBankViewModel Bank { get; set; }
    }
}
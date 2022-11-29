using Com.Efrata.Service.Finance.Accounting.Lib.Utilities.BaseClass;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.MemorialDetail
{
    public class GarmentFinanceMemorialDetailRupiahItemViewModel : BaseViewModel
    {
        public ChartOfAccountViewModel Account { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}

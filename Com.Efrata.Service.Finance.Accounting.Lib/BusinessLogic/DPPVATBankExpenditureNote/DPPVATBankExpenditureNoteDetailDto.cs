using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.DPPVATBankExpenditureNote
{
    public class DPPVATBankExpenditureNoteDetailDto
    {
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public int InternalNoteId { get; set; }
        public string InternalNoteNo { get; set; }
        public double Amount { get; set; }
        public double PaidAmount { get; set; }
    }
}

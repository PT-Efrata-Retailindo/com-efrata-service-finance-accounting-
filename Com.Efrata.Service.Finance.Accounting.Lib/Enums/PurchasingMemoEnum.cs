using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Enums
{
    public enum PurchasingMemoType
    {
        [Description("Disposisi")]
        Disposition = 1,
        [Description("Tanpa Disposisi")]
        NonDisposition
    }
}

using Com.Efrata.Service.Finance.Accounting.Lib.Models.DPPVATBankExpenditureNote;
using System;
using System.Collections.Generic;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.DPPVATBankExpenditureNote
{
    public class ReportDto
    {
        public ReportDto(DPPVATBankExpenditureNoteDetailModel detail, DPPVATBankExpenditureNoteItemModel itemDetail, DPPVATBankExpenditureNoteModel documentItem)
        {
            ExpenditureId = documentItem.Id;
            ExpenditureNoteNo = documentItem.DocumentNo;
            ExpenditureDate = documentItem.Date;
            CategoryName = detail.CategoryName;
            PaymentMethod = detail.PaymentMethod;
            DPP = itemDetail.DPP;
            VAT = itemDetail.VATAmount;
            Amount = documentItem.Amount;
            CurrencyCode = documentItem.CurrencyCode;
            CurrencyRate = documentItem.CurrencyRate;
            BankName = documentItem.BankName;
            SupplierId = itemDetail.SupplierId;
            SupplierName = itemDetail.SupplierName;
            InternalNoteId = itemDetail.InternalNoteId;
            InternalNoteNo = itemDetail.InternalNoteNo;
            InternalNoteAmount = itemDetail.TotalAmount;
            OutstandingAmount = itemDetail.OutstandingAmount;
            InvoiceId = detail.InvoiceId;
            InvoiceNo = detail.InvoiceNo;
            InvoiceAmount = detail.Amount;
            PaidAmount = itemDetail.TotalAmount;
            Difference = InternalNoteAmount - PaidAmount;
            BillsNo = detail.BillsNo;
            PaymentBills = detail.PaymentBills;
            SupplierCode = itemDetail.SupplierCode;
            DeliveryOrdersNo = detail.DeliveryOrdersNo;
            AmountDetail = detail.Amount;
            PaidAmountDetail = detail.PaidAmount;
        }
        public ReportDto(DPPVATBankExpenditureNoteDetailModel detail, DPPVATBankExpenditureNoteItemModel itemDetail, DPPVATBankExpenditureNoteModel documentItem,DPPVATBankExpenditureNoteDetailDoModel detailDo)
        {
            ExpenditureId = documentItem.Id;
            ExpenditureNoteNo = documentItem.DocumentNo;
            ExpenditureDate = documentItem.Date;
            CategoryName = detail.CategoryName;
            PaymentMethod = detail.PaymentMethod;
            DPP = itemDetail.DPP;
            VAT = itemDetail.VATAmount;
            Amount = documentItem.Amount;
            CurrencyCode = documentItem.CurrencyCode;
            CurrencyRate = documentItem.CurrencyRate;
            BankName = documentItem.BankName;
            SupplierId = itemDetail.SupplierId;
            SupplierName = itemDetail.SupplierName;
            InternalNoteId = itemDetail.InternalNoteId;
            InternalNoteNo = itemDetail.InternalNoteNo;
            InternalNoteAmount = itemDetail.TotalAmount;
            OutstandingAmount = itemDetail.OutstandingAmount;
            InvoiceId = detail.InvoiceId;
            InvoiceNo = detail.InvoiceNo;
            InvoiceAmount = detail.Amount;
            PaidAmount = itemDetail.TotalAmount;
            Difference = InternalNoteAmount - PaidAmount;
            BillsNo = detailDo.BillNo;
            PaymentBills = detailDo.PaymentBill;
            SupplierCode = itemDetail.SupplierCode;
            DeliveryOrdersNo = detailDo.DONo;
            AmountDetail = detailDo.TotalAmount;
            DPPVATDetailId = detail.Id;
            PaidAmountDetail = detail.PaidAmount;
        }

        public ReportDto(DPPVATBankExpenditureNoteDetailModel detail, DPPVATBankExpenditureNoteItemModel itemDetail, DPPVATBankExpenditureNoteModel documentItem, List<ReportDoDetailDto> detailSj)
        {
            ExpenditureId = documentItem.Id;
            ExpenditureNoteNo = documentItem.DocumentNo;
            ExpenditureDate = documentItem.Date;
            CategoryName = detail.CategoryName;
            PaymentMethod = detail.PaymentMethod;
            DPP = itemDetail.DPP;
            VAT = itemDetail.VATAmount;
            Amount = documentItem.Amount;
            CurrencyCode = documentItem.CurrencyCode;
            CurrencyRate = documentItem.CurrencyRate;
            BankName = documentItem.BankName;
            SupplierId = itemDetail.SupplierId;
            SupplierName = itemDetail.SupplierName;
            InternalNoteId = itemDetail.InternalNoteId;
            InternalNoteNo = itemDetail.InternalNoteNo;
            InternalNoteAmount = itemDetail.TotalAmount;
            OutstandingAmount = itemDetail.OutstandingAmount;
            InvoiceId = detail.InvoiceId;
            InvoiceNo = detail.InvoiceNo;
            InvoiceAmount = detail.Amount;
            PaidAmount = itemDetail.TotalAmount;
            Difference = InternalNoteAmount - PaidAmount;
            BillsNo = detail.BillsNo;
            PaymentBills = detail.PaymentBills;
            SupplierCode = itemDetail.SupplierCode;
            DeliveryOrdersNo = detail.DeliveryOrdersNo;
            AmountDetail = detail.Amount;
            DetailDO = detailSj;
            PaidAmountDetail = detail.PaidAmount;
        }

        public int ExpenditureId { get;  set; }
        public string ExpenditureNoteNo { get;  set; }
        public DateTimeOffset ExpenditureDate { get;  set; }
        public string CategoryName { get;  set; }
        public string PaymentMethod { get;  set; }
        public double DPP { get;  set; }
        public double VAT { get;  set; }
        public double Amount { get;  set; }
        public string CurrencyCode { get;  set; }
        public double CurrencyRate { get;  set; }
        public string BankName { get;  set; }
        public int SupplierId { get;  set; }
        public string SupplierName { get;  set; }
        public int InternalNoteId { get;  set; }
        public string InternalNoteNo { get;  set; }
        public double InternalNoteAmount { get;  set; }
        public double OutstandingAmount { get;  set; }
        public int InvoiceId { get;  set; }
        public string InvoiceNo { get;  set; }
        public double InvoiceAmount { get;  set; }
        public double PaidAmount { get;  set; }
        public double Difference { get;  set; }
        public string BillsNo { get;  set; }
        public string PaymentBills { get;  set; }
        public string DeliveryOrdersNo { get;  set; }
        public object SupplierCode { get;  set; }
        public double AmountDetail { get;  set; }
        public int DPPVATDetailId { get; set; }
        public double PaidAmountDetail { get;  set; }
        public List<ReportDoDetailDto> DetailDO { get;  set; }
    }
}
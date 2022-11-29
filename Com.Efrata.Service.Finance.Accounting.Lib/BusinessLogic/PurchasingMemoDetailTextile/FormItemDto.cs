namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.PurchasingMemoDetailTextile
{
    public class FormItemDto
    {
        public FormItemDto(DispositionDto disposition)
        {
            Disposition = disposition;
        }

        public DispositionDto Disposition { get; set; }
    }
}
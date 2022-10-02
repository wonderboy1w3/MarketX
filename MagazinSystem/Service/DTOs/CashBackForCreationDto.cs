namespace MagazinSystem.Service.DTOs
{
    public class CashBackForCreationDto : GenericDto
    {
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public decimal Discount { get; set; }
    }
}

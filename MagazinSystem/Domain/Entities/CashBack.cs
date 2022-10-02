namespace MagazinSystem.Domain.Entities
{
    public class CashBack : Auditable
    {
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public decimal Discount { get; set; }
    }
}

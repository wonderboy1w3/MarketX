using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class SoldLiquid : Auditable
    {
        public int Count { get; set; }
        public LiquidType LiquidType { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}

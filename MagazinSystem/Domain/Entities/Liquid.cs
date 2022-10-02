using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class Liquid : Auditable
    {
        public LiquidType LiquidType { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}

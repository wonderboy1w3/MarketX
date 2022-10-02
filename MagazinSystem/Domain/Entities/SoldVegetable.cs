using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class SoldVegetable : Auditable
    {
        public int Count { get; set; }
        public VegetableType VegetableType { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}

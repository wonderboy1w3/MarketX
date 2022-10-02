using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class Vegetable : Auditable
    {
        public VegetableType VegetableType { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}

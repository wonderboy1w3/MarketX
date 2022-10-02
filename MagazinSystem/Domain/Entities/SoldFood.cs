using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class SoldFood : Auditable
    {
        public int Count { get; set; }
        public FoodType FoodType { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}

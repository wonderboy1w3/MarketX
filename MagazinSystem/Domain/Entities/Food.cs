using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Domain.Entities
{
    public class Food : Auditable
    {
        public FoodType FoodType { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}

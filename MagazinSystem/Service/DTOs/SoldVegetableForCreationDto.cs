using MagazinSystem.Domain.Entities;
using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class SoldVegetableForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public VegetableType Vegetable { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}

using MagazinSystem.Domain.Entities;
using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class SoldLiquidForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public LiquidType Vegetable { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}

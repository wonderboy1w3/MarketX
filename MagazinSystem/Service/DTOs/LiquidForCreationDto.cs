using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class LiquidForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public LiquidType LiquidType { get; set; }
        public decimal Price { get; set; }
    }
}

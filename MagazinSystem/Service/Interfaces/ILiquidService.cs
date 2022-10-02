using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;

namespace MagazinSystem.Service.Interfaces
{
    public interface ILiquidService : IGenericService<Liquid, LiquidForCreationDto>
    {
        public Liquid Sell(long id, int count, SoldLiquidForCreationDto forCreationDto);
    }
}

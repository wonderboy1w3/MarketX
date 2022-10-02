using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;

namespace MagazinSystem.Service.Interfaces
{
    public interface ISoldLiquidService : IGenericService<SoldLiquid, SoldLiquidForCreationDto>
    {
    }
}

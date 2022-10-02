using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;

namespace MagazinSystem.Service.Interfaces
{
    public interface IVegetableService : IGenericService<Vegetable, VegetableForCreationDto>
    {
        public Vegetable Sell(long id, int count, SoldVegetableForCreationDto forCreationDto);
    }
}

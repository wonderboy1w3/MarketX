using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;

namespace MagazinSystem.Service.Interfaces
{
    public interface IFoodService : IGenericService<Food, FoodForCreationDto>
    {
        public Food Sell(long id, int count, SoldFoodForCreationDto forCreationDto);
    }
}

using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;

namespace MagazinSystem.Service.Services
{
    public class SoldFoodService : ISoldFoodService
    {
        ISoldFoodRepository soldFoodRepository;
        public SoldFoodService()
        {
            soldFoodRepository = new SoldFoodRepository();
        }
        public SoldFood Create(SoldFoodForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return soldFoodRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => soldFoodRepository.Delete(id);

        public SoldFood Get(int id)
            => soldFoodRepository.Get(id);

        public IEnumerable<SoldFood> GetAll()
            => soldFoodRepository.GetAll();

        public SoldFood Update(int id, SoldFoodForCreationDto forCreation)
            => soldFoodRepository.Update(id, ConvertTo(forCreation));

        private SoldFood ConvertTo(SoldFoodForCreationDto forCreationDto)
        {
            return new SoldFood()
            {
                Seller = forCreationDto.Seller,
                Count = forCreationDto.Count,
                Price = forCreationDto.Price,
                FoodType = forCreationDto.FoodType
            };
        }
    }
}

using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MagazinSystem.Service.Services
{
    public class FoodService : IFoodService
    {
        IFoodRepository foodRepository;
        ISoldFoodRepository soldFoodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
            soldFoodRepository = new SoldFoodRepository();
        }
        public Food Create(FoodForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return foodRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => foodRepository.Delete(id);

        public Food Get(int id)
            => foodRepository.Get(id);

        public IEnumerable<Food> GetAll()
            => foodRepository.GetAll();

        public Food Sell(long id, int count, SoldFoodForCreationDto forCreationDto)
        {
            var products = foodRepository.GetAll().FirstOrDefault(p => p.Id == id);

            products.Count -= count;
            foodRepository.Update(id, products);

            soldFoodRepository.Create(ConvertTo(products));

            return products;
        }

        public Food Update(int id, FoodForCreationDto forCreation)
            => foodRepository.Update(id, ConvertTo(forCreation));

        private Food ConvertTo(FoodForCreationDto forCreationDto)
        {
            return new Food()
            {
                Count = forCreationDto.Count,
                Price = forCreationDto.Price,
                FoodType = forCreationDto.FoodType
            };
        }

        private SoldFood ConvertTo(Food products)
        {
            return new SoldFood()
            {
                FoodType = products.FoodType,
                Count = products.Count,
                Price = products.Price
            };
        }
    }
}

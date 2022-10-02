using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MagazinSystem.Service.Services
{
    public class VegetableService : IVegetableService
    {
        IVegetableRepository vegetableRepository;
        ISoldVegetableRepository soldVegetableRepository;
        public VegetableService()
        {
            vegetableRepository = new VegetableRepository();
            soldVegetableRepository = new SoldVegetableRepository();
        }

        public Vegetable Create(VegetableForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return vegetableRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => vegetableRepository.Delete(id);

        public Vegetable Get(int id)
            => vegetableRepository.Get(id);

        public IEnumerable<Vegetable> GetAll()
            => vegetableRepository.GetAll();

        public Vegetable Sell(long id, int count, SoldVegetableForCreationDto forCreationDto)
        {
            var products = vegetableRepository.GetAll().FirstOrDefault(p => p.Id == id);

            products.Count -= count;
            vegetableRepository.Update(id, products);

            soldVegetableRepository.Create(ConvertTo(products));

            return products;
        }

        public Vegetable Update(int id, VegetableForCreationDto forCreation)
            => vegetableRepository.Update(id, ConvertTo(forCreation));

        private Vegetable ConvertTo(VegetableForCreationDto forCreationDto)
        {
            return new Vegetable()
            {
                Count = forCreationDto.Count,
                Price = forCreationDto.Price,
                VegetableType = forCreationDto.VegetableType
            };
        }

        private SoldVegetable ConvertTo(Vegetable products)
        {
            return new SoldVegetable()
            {
                VegetableType = products.VegetableType,
                Count = products.Count,
                Price = products.Price
            };
        }
    }
}

using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;

namespace MagazinSystem.Service.Services
{
    public class SoldVegetableService : ISoldVegetableService
    {
        ISoldVegetableRepository soldVegetableRepository;
        public SoldVegetableService()
        {
            soldVegetableRepository = new SoldVegetableRepository();
        }

        public SoldVegetable Create(SoldVegetableForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return soldVegetableRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => soldVegetableRepository.Delete(id);

        public SoldVegetable Get(int id)
            => soldVegetableRepository.Get(id);

        public IEnumerable<SoldVegetable> GetAll()
            => soldVegetableRepository.GetAll();

        public SoldVegetable Update(int id, SoldVegetableForCreationDto forCreation)
            => soldVegetableRepository.Update(id, ConvertTo(forCreation));

        private SoldVegetable ConvertTo(SoldVegetableForCreationDto forCreationDto)
        {
            return new SoldVegetable()
            {
                Seller = forCreationDto.Seller,
                Count = forCreationDto.Count,
                Price = forCreationDto.Price,
                VegetableType = forCreationDto.Vegetable
            };
        }
    }
}

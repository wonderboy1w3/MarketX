using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;

namespace MagazinSystem.Service.Services
{
    public class SoldLiquidService : ISoldLiquidService
    {
        ISoldLiquidRepository soldLiquidRepository;
        public SoldLiquidService()
        {
            soldLiquidRepository = new SoldLiquidRepository();
        }
        public SoldLiquid Create(SoldLiquidForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return soldLiquidRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => soldLiquidRepository.Delete(id);

        public SoldLiquid Get(int id)
            => soldLiquidRepository.Get(id);

        public IEnumerable<SoldLiquid> GetAll()
            => soldLiquidRepository.GetAll();

        public SoldLiquid Update(int id, SoldLiquidForCreationDto forCreation)
            => soldLiquidRepository.Update(id, ConvertTo(forCreation));

        private SoldLiquid ConvertTo(SoldLiquidForCreationDto forCreationDto)
        {
            return new SoldLiquid()
            {
                Seller = forCreationDto.Seller,
                Price = forCreationDto.Price,
                Count = forCreationDto.Count,
                LiquidType = forCreationDto.Vegetable

            };
        }
    }
}

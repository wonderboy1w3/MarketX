using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MagazinSystem.Service.Services
{
    public class LiquidService : ILiquidService
    {
        ILiquidRepository liquidRepository;
        ISoldLiquidRepository soldLiquidRepository;
        public LiquidService()
        {
            liquidRepository = new LiquidRepository();
            soldLiquidRepository = new SoldLiquidRepository();
        }
        public Liquid Create(LiquidForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return liquidRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => liquidRepository.Delete(id);

        public Liquid Get(int id)
            => liquidRepository.Get(id);

        public IEnumerable<Liquid> GetAll()
            => liquidRepository.GetAll();

        public Liquid Sell(long id, int count, SoldLiquidForCreationDto forCreationDto)
        {
            var products = liquidRepository.GetAll().FirstOrDefault(p => p.Id == id);

            products.Count -= count;
            liquidRepository.Update(id, products);

            soldLiquidRepository.Create(ConvertTo(products));

            return products;
        }

        public Liquid Update(int id, LiquidForCreationDto forCreation)
            => liquidRepository.Update(id, ConvertTo(forCreation));

        private Liquid ConvertTo(LiquidForCreationDto forCreation)
        {
            return new Liquid()
            {
                LiquidType = forCreation.LiquidType,
                Count = forCreation.Count,
                Price = forCreation.Price,
            };
        }

        private SoldLiquid ConvertTo(Liquid products)
        {
            return new SoldLiquid()
            {
                LiquidType = products.LiquidType,
                Count = products.Count,
                Price = products.Price
            };
        }
    }
}

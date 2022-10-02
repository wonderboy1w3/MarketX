using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;

namespace MagazinSystem.Service.Services
{
    public class SellerService : ISellerService
    {
        ISellerRepository sellerRepository;
        public SellerService()
        {
            sellerRepository = new SellerRepository();
        }

        public Seller Create(SellerForCreationDto forCreation)
        {
            if (forCreation is null)
                return null;

            return sellerRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => sellerRepository.Delete(id);

        public Seller Get(int id)
            => sellerRepository.Get(id);

        public IEnumerable<Seller> GetAll()
            => sellerRepository.GetAll();

        public Seller Update(int id, SellerForCreationDto forCreation)
            => sellerRepository.Update(id, ConvertTo(forCreation));

        private Seller ConvertTo(SellerForCreationDto forCreationDto)
        {
            return new Seller()
            {
                Name = forCreationDto.Name,
            };
        }
    }
}

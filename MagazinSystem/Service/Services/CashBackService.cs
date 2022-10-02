using MagazinSystem.Data.IRepository;
using MagazinSystem.Data.Repository;
using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MagazinSystem.Service.Services
{
    public class CashBackService : ICashBackService
    {
        ICashBackRepository cashBackRepository;
        public CashBackService()
        {
            cashBackRepository = new CashBackRepository();
        }

        public CashBack Create(CashBackForCreationDto forCreation)
        {
            if (forCreation == null)
                return null;

            return cashBackRepository.Create(ConvertTo(forCreation));
        }

        public bool Delete(int id)
            => cashBackRepository.Delete(id);

        public CashBack Get(int id)
            => cashBackRepository.Get(id);

        public IEnumerable<CashBack> GetAll()
            => cashBackRepository.GetAll();

        public CashBack Update(int id, CashBackForCreationDto forCreation)
            => cashBackRepository.Update(id, ConvertTo(forCreation));

        public CashBack UseCashBack(int id, decimal sum)
        {
            var cash = cashBackRepository.Get(id);

            var cash2 = cashBackRepository.GetAll().FirstOrDefault(p => p.Id == id);

            cash.Discount -= sum;

            return Update(id, ConvertTo(cash2));
        }

        private CashBackForCreationDto ConvertTo(CashBack cash2)
        {
            return new CashBackForCreationDto()
            {
                PersonName = cash2.PersonName,
                Phone = cash2.Phone,
                Discount = cash2.Discount
            };
        }

        private CashBack ConvertTo(CashBackForCreationDto forCreationDto)
        {
            return new CashBack()
            {
                PersonName = forCreationDto.PersonName,
                Phone = forCreationDto.Phone,
                Discount = forCreationDto.Discount
            };
        }
    }
}

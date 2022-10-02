using MagazinSystem.Domain.Entities;
using MagazinSystem.Service.DTOs;

namespace MagazinSystem.Service.Interfaces
{
    public interface ICashBackService : IGenericService<CashBack, CashBackForCreationDto>
    {
        public CashBack UseCashBack(int id, decimal sum);
    }
}

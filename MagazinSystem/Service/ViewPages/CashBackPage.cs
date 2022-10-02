using ConsoleTables;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using MagazinSystem.Service.Services;
using Sharprompt;

namespace MagazinSystem.Service.ViewPages
{
    public class CashBackPage
    {
        ICashBackService cashBackService = new CashBackService();
        public void Create()
        {
            var name = Prompt.Input<string>("Enter name: ");

            var phone = Prompt.Input<string>("Enter Phone: ");

            CashBackForCreationDto forCreationDto = new CashBackForCreationDto()
            {
                PersonName = name,
                Phone = phone
            };

            cashBackService.Create(forCreationDto);
        }

        public void Delete()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            cashBackService.Delete(id);
        }

        public void Update()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var name = Prompt.Input<string>("Enter name: ");

            var phone = Prompt.Input<string>("Enter Phone: ");

            CashBackForCreationDto forCreationDto = new CashBackForCreationDto()
            {
                PersonName = name,
                Phone = phone
            };

            cashBackService.Update(id, forCreationDto);
        }

        public void Get()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var cash = cashBackService.Get(id);

            ConsoleTable table = new ConsoleTable("Name", "Phone", "Discount");
            table.AddRow(cash.PersonName, cash.Phone, cash.Discount);
            table.Write();
        }

        public void GetAll()
        {
            foreach (var cash in cashBackService.GetAll())
            {
                ConsoleTable table = new ConsoleTable("Name", "Phone", "Discount");
                table.AddRow(cash.PersonName, cash.Phone, cash.Discount);
                table.Write();
            }
        }
    }
}

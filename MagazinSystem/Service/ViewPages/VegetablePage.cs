using ConsoleTables;
using MagazinSystem.Domain.Enums;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using MagazinSystem.Service.Services;
using Sharprompt;

namespace MagazinSystem.Service.ViewPages
{
    public class VegetablePage
    {
        IVegetableService vegetableService = new VegetableService();
        public void Create()
        {
            var types = Prompt.Select("Select type", new[] { "1.Tomato", "2.Potato", "3.Cucumber", "4.Carrot", "5.Onion" });
            VegetableType foodType = (VegetableType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            VegetableForCreationDto forCreationDto = new VegetableForCreationDto()
            {
                VegetableType = foodType,
                Count = count,
                Price = price

            };

            vegetableService.Create(forCreationDto);
        }

        public void Delete()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            vegetableService.Delete(id);
        }

        public void Update()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var types = Prompt.Select("Select type", new[] { "1.Tomato", "2.Potato", "3.Cucumber", "4.Carrot", "5.Onion" });
            VegetableType foodType = (VegetableType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            VegetableForCreationDto forCreationDto = new VegetableForCreationDto()
            {
                VegetableType = foodType,
                Count = count,
                Price = price

            };

            vegetableService.Update(id, forCreationDto);
        }

        public void Get()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var vegetable = vegetableService.Get(id);

            ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
            table.AddRow(vegetable.VegetableType, vegetable.Price, vegetable.Count);
            table.Write();
        }

        public void GetAll()
        {
            foreach (var vegetable in vegetableService.GetAll())
            {
                ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
                table.AddRow(vegetable.VegetableType, vegetable.Price, vegetable.Count);
                table.Write();
            }
        }
    }
}

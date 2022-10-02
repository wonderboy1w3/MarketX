using ConsoleTables;
using MagazinSystem.Domain.Enums;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using MagazinSystem.Service.Services;
using Sharprompt;

namespace MagazinSystem.Service.ViewPages
{
    public class LiquidPage
    {
        ILiquidService liquidService = new LiquidService();
        public void Create()
        {
            var types = Prompt.Select("Select type", new[] { "1.Cola", "2.Pepsi", "3.Tea", "4.Milk", "5.Juice" });
            LiquidType foodType = (LiquidType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            LiquidForCreationDto forCreationDto = new LiquidForCreationDto()
            {
                LiquidType = foodType,
                Count = count,
                Price = price

            };

            liquidService.Create(forCreationDto);
        }

        public void Delete()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            liquidService.Delete(id);
        }

        public void Update()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var types = Prompt.Select("Select type", new[] { "1.Cola", "2.Pepsi", "3.Tea", "4.Milk", "5.Juice" });
            LiquidType foodType = (LiquidType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            LiquidForCreationDto forCreationDto = new LiquidForCreationDto()
            {
                LiquidType = foodType,
                Count = count,
                Price = price

            };


            liquidService.Update(id, forCreationDto);
        }

        public void Get()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var liquid = liquidService.Get(id);

            ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
            table.AddRow(liquid.LiquidType, liquid.Price, liquid.Count);
            table.Write();
        }

        public void GetAll()
        {
            foreach (var liquid in liquidService.GetAll())
            {
                ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
                table.AddRow(liquid.LiquidType, liquid.Price, liquid.Count);
                table.Write();
            }
        }
    }
}

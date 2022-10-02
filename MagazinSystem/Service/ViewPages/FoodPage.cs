using ConsoleTables;
using MagazinSystem.Domain.Enums;
using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using MagazinSystem.Service.Services;
using Sharprompt;

namespace MagazinSystem.Service.ViewPages
{
    public class FoodPage
    {
        IFoodService foodService = new FoodService();
        public void Create()
        {
            var types = Prompt.Select("Select type", new[] { "1.Meal", "2.Bread", "3.Sweet", "4.Cake" });
            FoodType foodType = (FoodType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            FoodForCreationDto forCreationDto = new FoodForCreationDto()
            {
                FoodType = foodType,
                Count = count,
                Price = price

            };

            foodService.Create(forCreationDto);
        }

        public void Delete()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            foodService.Delete(id);
        }

        public void Update()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var types = Prompt.Select("Select type", new[] { "1.Meal", "2.Bread", "3.Sweet", "4.Cake" });
            FoodType foodType = (FoodType)((int)types[0]) - 48;

            var count = Prompt.Input<int>("Enter count: ");

            var price = Prompt.Input<decimal>("Enter price: ");

            FoodForCreationDto forCreationDto = new FoodForCreationDto()
            {
                FoodType = foodType,
                Count = count,
                Price = price

            };

            foodService.Update(id, forCreationDto);
        }

        public void Get()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var food = foodService.Get(id);

            ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
            table.AddRow(food.FoodType, food.Price, food.Count);
            table.Write();
        }

        public void GetAll()
        {
            foreach (var food in foodService.GetAll())
            {
                ConsoleTable table = new ConsoleTable("Name", "Price", "Count");
                table.AddRow(food.FoodType, food.Price, food.Count);
                table.Write();
            }
        }
    }
}

using MagazinSystem.Service.ViewPages;
using Sharprompt;

namespace MagazinSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAdminRepository adminRepository = new AdimRepository 
            AdminPage adminPage = new AdminPage();
            FoodPage foodPage = new FoodPage();
            LiquidPage liquidPage = new LiquidPage();
            VegetablePage vegetablePage = new VegetablePage();
            CashBackPage cashBackPage = new CashBackPage();

            var choices = Prompt.Select("Select one", new[] { "1.Admin", "2.Seller", "3.Client" });

            var choice = ((int)choices[0]) - 48;

        start:

            if (choice == 1)
            {
                var password = Prompt.Password("Enter password", validators: new[] { Validators.Required(), Validators.MinLength(6) });

                if (password.Equals("qwerty"))
                {
                    var parts = Prompt.Select("Select one", new[] { "1.Products", "2.Sellers", "3.Cashbacks" });
                    var part = ((int)choices[0]) - 48;

                    if (part == 1)
                    {
                        var products = Prompt.Select("Select one", new[] { "1.Foods", "2.Liquids", "3.Vegetables" });
                        var product = ((int)choices[0]) - 48;

                        if (product == 1)
                        {
                            var foods = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                            var food = ((int)choices[0]) - 48;

                            if (food == 1)
                                foodPage.Create();

                            else if (food == 2)
                                foodPage.Delete();

                            else if (food == 3)
                                foodPage.Update();

                            else if (food == 4)
                                foodPage.Get();

                            else if (food == 5)
                                foodPage.GetAll();
                            else return;
                        }

                        else if (product == 2)
                        {
                            var liquids = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                            var liquid = ((int)choices[0]) - 48;

                            if (liquid == 1)
                                liquidPage.Create();

                            else if (liquid == 2)
                                liquidPage.Delete();

                            else if (liquid == 3)
                                liquidPage.Update();

                            else if (liquid == 4)
                                liquidPage.Get();

                            else if (liquid == 5)
                                liquidPage.GetAll();
                            else return;
                        }

                        else if (product == 3)
                        {
                            var vegetables = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                            var vegetable = ((int)choices[0]) - 48;

                            if (vegetable == 1)
                                vegetablePage.Create();

                            else if (vegetable == 2)
                                vegetablePage.Delete();

                            else if (vegetable == 3)
                                vegetablePage.Update();

                            else if (vegetable == 4)
                                vegetablePage.Get();

                            else if (vegetable == 5)
                                vegetablePage.GetAll();
                            else return;
                        }
                        else return;
                    }

                    else if (part == 2)
                    {
                        var sellers = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                        var seller = ((int)choices[0]) - 48;

                        if (seller == 1)
                            adminPage.CreateSeller();

                        else if (seller == 2)
                            adminPage.DeleteSeller();

                        else if (seller == 3)
                            adminPage.Update();

                        else if (seller == 4)
                            adminPage.GetSeller();

                        else if (seller == 5)
                            adminPage.GetAllSeller();
                        else return;
                    }

                    else if (part == 3)
                    {
                        var cashs = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                        var cash = ((int)choices[0]) - 48;

                        if (cash == 1)
                            cashBackPage.Create();

                        else if (cash == 2)
                            cashBackPage.Delete();

                        else if (cash == 3)
                            cashBackPage.Update();

                        else if (cash == 4)
                            cashBackPage.Get();

                        else if (cash == 5)
                            cashBackPage.GetAll();
                        else return;
                    }

                    else return;
                }
            }

            else if (choice == 2)
            {
                var cs = Prompt.Select("Select one", new[] { "1.Products", "2.Cashbacks" });

                var c = ((int)choices[0]) - 48;

                if (c == 1)
                {

                    var products = Prompt.Select("Select one", new[] { "1.Foods", "2.Liquids", "3.Vegetables" });
                    var product = ((int)choices[0]) - 48;

                    if (product == 1)
                    {
                        var foods = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                        var food = ((int)choices[0]) - 48;

                        if (food == 1)
                            foodPage.Create();

                        else if (food == 2)
                            foodPage.Delete();

                        else if (food == 3)
                            foodPage.Update();

                        else if (food == 4)
                            foodPage.Get();

                        else if (food == 5)
                            foodPage.GetAll();
                        else return;
                    }

                    else if (product == 2)
                    {
                        var liquids = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                        var liquid = ((int)choices[0]) - 48;

                        if (liquid == 1)
                            liquidPage.Create();

                        else if (liquid == 2)
                            liquidPage.Delete();

                        else if (liquid == 3)
                            liquidPage.Update();

                        else if (liquid == 4)
                            liquidPage.Get();

                        else if (liquid == 5)
                            liquidPage.GetAll();
                        else return;
                    }

                    else if (product == 3)
                    {
                        var vegetables = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                        var vegetable = ((int)choices[0]) - 48;

                        if (vegetable == 1)
                            vegetablePage.Create();

                        else if (vegetable == 2)
                            vegetablePage.Delete();

                        else if (vegetable == 3)
                            vegetablePage.Update();

                        else if (vegetable == 4)
                            vegetablePage.Get();

                        else if (vegetable == 5)
                            vegetablePage.GetAll();
                        else return;
                    }
                    else return;
                }

                else if (c == 2)
                {
                    var cashs = Prompt.Select("Select one", new[] { "1.Create", "2.Delete", "3.Update", "4.Get", "5.GetAll" });
                    var cash = ((int)choices[0]) - 48;

                    if (cash == 1)
                        cashBackPage.Create();

                    else if (cash == 2)
                        cashBackPage.Delete();

                    else if (cash == 3)
                        cashBackPage.Update();

                    else if (cash == 4)
                        cashBackPage.Get();

                    else if (cash == 5)
                        cashBackPage.GetAll();
                    else return;
                }

                else return;
            }

            if (choice == 3)
            {

                var products = Prompt.Select("Select one", new[] { "1.Foods", "2.Liquids", "3.Vegetables" });
                var product = ((int)choices[0]) - 48;

                if (product == 1)
                {
                    var foods = Prompt.Select("Select one", new[] { "1.Get", "2.GetAll", "3.Sell" });
                    var food = ((int)choices[0]) - 48;

                    if (food == 1)
                        foodPage.Get();

                    else if (food == 2)
                        foodPage.GetAll();

                    else return;
                }

                else if (product == 2)
                {
                    var liquids = Prompt.Select("Select one", new[] { "1.Get", "2.GetAll", "3.Sell" });
                    var liquid = ((int)choices[0]) - 48;

                    if (liquid == 1)
                        liquidPage.Get();

                    else if (liquid == 2)
                        liquidPage.GetAll();

                    else return;
                }

                else if (product == 3)
                {
                    var vegetables = Prompt.Select("Select one", new[] { "1.Get", "2.GetAll", "3.Sell" });
                    var vegetable = ((int)choices[0]) - 48;

                    if (vegetable == 1)
                        vegetablePage.Get();

                    else if (vegetable == 2)
                        vegetablePage.GetAll();

                    else return;
                }

                else return;
            }

            else return;

            goto start;
        }
    }
}

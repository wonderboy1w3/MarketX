using Sharprompt;
using System;

namespace MagazinSystem.Service.ViewPages
{
    public class SellerPage
    {
        void ShowProducts()
        {
            var name = Prompt.Input<string>("What's your name?");
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

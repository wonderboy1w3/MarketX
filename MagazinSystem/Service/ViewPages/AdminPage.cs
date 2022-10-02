using MagazinSystem.Service.DTOs;
using MagazinSystem.Service.Interfaces;
using MagazinSystem.Service.Services;
using Sharprompt;

namespace MagazinSystem.Service.ViewPages
{
    public class AdminPage
    {
        ISellerService sellerService = new SellerService();

        public void CreateSeller()
        {
            var sellerName = Prompt.Input<string>("Seller name: ");

            SellerForCreationDto sellerForCreationDto = new SellerForCreationDto()
            {
                Name = sellerName,
            };

            sellerService.Create(sellerForCreationDto);
        }

        public void DeleteSeller()
        {
            int id = Prompt.Input<int>("Enter Id: ");

            sellerService.Delete(id);
        }

        public void Update()
        {
            var id = Prompt.Input<int>("Enter ID: ");

            var sellerName = Prompt.Input<string>("Seller name: ");

            SellerForCreationDto sellerForCreationDto = new SellerForCreationDto()
            {
                Name = sellerName,
            };

            sellerService.Update(id, sellerForCreationDto);
        }

        public void GetSeller()
        {
            int id = Prompt.Input<int>("Enter Id: ");
            sellerService.Get(id);
        }

        public void GetAllSeller()
        {
            sellerService.GetAll();
        }

    }
}

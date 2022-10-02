using MagazinSystem.Configuration;
using MagazinSystem.Data.IRepository;
using MagazinSystem.Domain.Entities;
using Newtonsoft.Json;
using System.IO;

namespace MagazinSystem.Data.Repository
{
    public class SoldFoodRepository : GenericRepository<SoldFood>, ISoldFoodRepository
    {
        public SoldFoodRepository()
        {
            var appSettings = ReadFromAppSetting();

            lastId = appSettings.DataBase.SoldFood.LastId;
            path = appSettings.DataBase.SoldFood.Path;
        }

        protected override int lastId { get; set; }
        protected override string path { get; set; }

        protected override void SaveToAppSetting()
        {
            var appSettings = ReadFromAppSetting();

            appSettings.DataBase.SoldFood.LastId = lastId;

            var json = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

            File.WriteAllText(Constants.APP_SETTING_PATH, json);
        }
    }
}

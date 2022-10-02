using MagazinSystem.Configuration;
using MagazinSystem.Data.IRepository;
using MagazinSystem.Domain.Entities;
using Newtonsoft.Json;
using System.IO;

namespace MagazinSystem.Data.Repository
{
    public class SoldVegetableRepository : GenericRepository<SoldVegetable>, ISoldVegetableRepository
    {
        public SoldVegetableRepository()
        {
            var appSettings = ReadFromAppSetting();

            lastId = appSettings.DataBase.SoldVegetable.LastId;
            path = appSettings.DataBase.SoldVegetable.Path;
        }

        protected override int lastId { get; set; }
        protected override string path { get; set; }

        protected override void SaveToAppSetting()
        {
            var appSettings = ReadFromAppSetting();

            appSettings.DataBase.SoldVegetable.LastId = lastId;

            var json = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

            File.WriteAllText(Constants.APP_SETTING_PATH, json);
        }
    }
}

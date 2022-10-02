using MagazinSystem.Configuration;
using MagazinSystem.Data.IRepository;
using MagazinSystem.Domain.Entities;
using Newtonsoft.Json;
using System.IO;

namespace MagazinSystem.Data.Repository
{
    public class VegetableRepository : GenericRepository<Vegetable>, IVegetableRepository
    {
        public VegetableRepository()
        {
            var appSettings = ReadFromAppSetting();

            lastId = appSettings.DataBase.Vegetable.LastId;
            path = appSettings.DataBase.Vegetable.Path;
        }

        protected override int lastId { get; set; }
        protected override string path { get; set; }

        protected override void SaveToAppSetting()
        {
            var appSettings = ReadFromAppSetting();

            appSettings.DataBase.Vegetable.LastId = lastId;

            var json = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

            File.WriteAllText(Constants.APP_SETTING_PATH, json);
        }
    }
}

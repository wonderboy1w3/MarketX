using MagazinSystem.Configuration;
using MagazinSystem.Data.IRepository;
using MagazinSystem.Domain.Entities;
using Newtonsoft.Json;
using System.IO;

namespace MagazinSystem.Data.Repository
{
    public class SoldLiquidRepository : GenericRepository<SoldLiquid>, ISoldLiquidRepository
    {
        public SoldLiquidRepository()
        {
            var appSettings = ReadFromAppSetting();

            lastId = appSettings.DataBase.SoldLiquid.LastId;
            path = appSettings.DataBase.SoldLiquid.Path;
        }

        protected override int lastId { get; set; }
        protected override string path { get; set; }

        protected override void SaveToAppSetting()
        {
            var appSettings = ReadFromAppSetting();

            appSettings.DataBase.SoldLiquid.LastId = lastId;

            var json = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

            File.WriteAllText(Constants.APP_SETTING_PATH, json);
        }
    }
}

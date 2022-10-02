using MagazinSystem.Configuration;
using MagazinSystem.Data.IRepository;
using MagazinSystem.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MagazinSystem.Data.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        protected abstract int lastId { get; set; }
        protected abstract string path { get; set; }

        public T Create(T source)
        {
            source.Id = ++lastId;
            source.CreateAt = DateTime.Now;

            File.WriteAllText(path, JsonConvert.SerializeObject(GetAll().Append(source), Formatting.Indented));

            SaveToAppSetting();

            return source;
        }

        public bool Delete(long id)
        {
            var source = Get(id);

            if (source == null)
                return false;

            File.WriteAllText(path, JsonConvert.SerializeObject(GetAll().Select(p => p.Id != id), Formatting.Indented));

            return true;
        }

        public T Get(long id)
            => GetAll().FirstOrDefault(p => p.Id == id);

        public T Update(long id, T source)
        {
            if (Get(id) == null)
                return null;

            source.UpdatedAt = DateTime.Now;
            source.Id = id;

            File.WriteAllText(path, JsonConvert.SerializeObject(GetAll().Select(p => p.Id != id ? p : source), Formatting.Indented));

            return source;
        }

        public IEnumerable<T> GetAll()
        {
            var json = File.ReadAllText(path);

            if (string.IsNullOrEmpty(json))
                File.WriteAllText(path, "[]");

            return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
        }

        public dynamic ReadFromAppSetting()
        {
            var json = File.ReadAllText(Constants.APP_SETTING_PATH);

            return JsonConvert.DeserializeObject<dynamic>(json);
        }

        protected abstract void SaveToAppSetting();
    }
}

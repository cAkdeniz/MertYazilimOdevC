using MertYazilim.Entities.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.ApiService
{
    public class ApiManager
    {
        private readonly HttpClient _httpClient;

        public ApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:32579/api/");
        }

        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class, IEntity, new()
        {
            var entities = entity.GetType().Name;

            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync($"{entities}", stringContent);
        }

        public async Task DeleteAsync<TEntity>(int id) where TEntity : class, IEntity, new()
        {
            TEntity entity = new TEntity();
            var entities = entity.GetType().Name;

            await _httpClient.DeleteAsync($"{entities}/{id}");
        }

        public async Task DeleteAsync<TEntity>(string id) where TEntity : class, IEntity, new()
        {
            TEntity entity = new TEntity();
            var entities = entity.GetType().Name;

            await _httpClient.DeleteAsync($"{entities}/{id}");
        }

        public async Task<List<TEntity>> GetAllAsync<TEntity>() where TEntity : class, IEntity, new()
        {
            TEntity entity = new TEntity();
            var entities = entity.GetType().Name;

            var response = await _httpClient.GetAsync($"{entities}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<TEntity>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class, IEntity, new()
        {
            TEntity entity = new TEntity();
            var entities = entity.GetType().Name;

            var response = await _httpClient.GetAsync($"{entities}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TEntity>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<TEntity> GetAsync<TEntity>(string id) where TEntity : class, IEntity, new()
        {
            TEntity entity = new TEntity();
            var entities = entity.GetType().Name;

            var response = await _httpClient.GetAsync($"{entities}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TEntity>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task UpdateAsync<TEntity>(TEntity entity, int id) where TEntity : class, IEntity, new()
        {
            var entities = entity.GetType().Name;

            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{entities}/{id}", stringContent);
        }

        public async Task UpdateAsync<TEntity>(TEntity entity, string id) where TEntity : class, IEntity, new()
        {
            var entities = entity.GetType().Name;

            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{entities}/{id}", stringContent);
        }
    }
}

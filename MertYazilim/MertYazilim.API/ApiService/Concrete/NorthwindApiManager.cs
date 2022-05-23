using MertYazilim.Entities.Abstract;
using MertYazilim.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.API.ApiService.Concrete
{
    public class NorthwindApiManager 
    {
        private readonly HttpClient _httpClient;
        private string _name;

        public NorthwindApiManager(string name)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://northwind.now.sh/api/");

            _name = name;
        }

        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class, IEntity, new()
        {
            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync($"{_name}", stringContent);
        }

        public async Task DeleteAsync<TEntity>(int id) where TEntity : class, IEntity, new()
        {
            await _httpClient.DeleteAsync($"{_name}/{id}");
        }

        public async Task DeleteAsync<TEntity>(string id) where TEntity : class, IEntity, new()
        {
            await _httpClient.DeleteAsync($"{_name}/{id}");
        }

        public async Task<List<TEntity>> GetAllAsync<TEntity>() where TEntity : class, IEntity, new()
        {
            var response = await _httpClient.GetAsync($"{_name}");

            if(response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<TEntity>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class, IEntity, new()
        {
            var response = await _httpClient.GetAsync($"{_name}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TEntity>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<TEntity> GetAsync<TEntity>(string id) where TEntity : class, IEntity, new()
        {
            var response = await _httpClient.GetAsync($"{_name}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TEntity>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task UpdateAsync<TEntity>(TEntity entity, int id) where TEntity : class, IEntity, new()
        {
            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{_name}/{id}", stringContent);
        }

        public async Task UpdateAsync<TEntity>(TEntity entity, string id) where TEntity : class, IEntity, new()
        {
            var jsonString = JsonConvert.SerializeObject(entity);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{_name}/{id}", stringContent);
        }
    }
}

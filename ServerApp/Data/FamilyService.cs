using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ServerApp.Model;

namespace ServerApp.Data
{
    public class FamilyService:IFamiliesData
    {
       private string uri = "https://localhost:5001";
        private readonly HttpClient client;

        public FamilyService()
        {
            client = new HttpClient();
        }
        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            HttpResponseMessage response = await client.GetAsync(uri + "/Adults");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Could not find adults");
            }

            string message = await response.Content.ReadAsStringAsync();
            IList<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return result;
        }

        Task IFamiliesData.GetAllFamiliesAsync()
        {
            return GetAllFamiliesAsync();
        }

       

        public async Task<IList<FamilyObject>> GetAllFamiliesAsync()
        {
            HttpResponseMessage response = await client.GetAsync(uri + "/Families");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("You are not the member of the family");
            }

            string message = await response.Content.ReadAsStringAsync();
            List<FamilyObject> result = JsonSerializer.Deserialize<List<FamilyObject>>(message, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return result;

        }

        public async Task NewFamilyAsync(FamilyObject familyObject)
        {
            string FamilyAsJson = JsonSerializer.Serialize(familyObject);
            HttpContent content = new StringContent(FamilyAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(uri + "/NewFamily", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error,{response.StatusCode},{response.ReasonPhrase}");
            }
        } 
    }
}
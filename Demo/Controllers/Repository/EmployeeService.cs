using Demo.Controllers.Repository.IRepository;
using Demo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System.Configuration;

namespace Demo.Controllers.Repository
{
    public class EmployeeService:IEmployeeService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        Uri url = new Uri("https://rc-vault-fap-live-1.azurewebsites.net/api/gettimeentries?code=vO17RnE8vuzXzPJo5eaLLjXjmRW07law99QTD90zat9FfOQJKKUcgQ==");
        private static readonly string uri;
     
        public EmployeeService()
        {
            _client = new HttpClient();
            _client.BaseAddress = url;        
        }
        
       
        public async Task<List<Employee>> GetEmployees()
        {
            var employee=  new List<Employee>();
            try
            {
                var response = await _client.GetAsync(url);


                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<List<Employee>>(json);
                }
            }
            catch (HttpRequestException ex)
            {
              
                return null;
                
            }
            return employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;

namespace NetCoreConsoleApp
{
    public class EmployeeGenerator
    {
        public static async IAsyncEnumerable<Employee> GetEmployees()
        {
            using HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.BaseAddress = new Uri("http://localhost:65162/api/");

            for (int i = 1; i <= 9; i++)
            {
                var response = await httpClient.GetAsync("employees/" + i);
                var employeeResponse = await response.Content.ReadAsStringAsync();
                var employee = JsonSerializer.Deserialize<Employee>(employeeResponse, new JsonSerializerOptions
                {

                    PropertyNameCaseInsensitive = true
                }) ;

                yield return employee;

            }

        }
    }
}

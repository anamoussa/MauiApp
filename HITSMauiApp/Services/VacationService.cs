using HITSMauiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HITSMauiApp.Services
{
    public class VacationService
    {
        HttpClient httpClient;
        public VacationService()
        {
            this.httpClient = new HttpClient();
        }

        List<Vacation> VacationList;
        public async Task<List<Vacation>> GetVacations()
        {
            if (VacationList?.Count > 0)
                return VacationList;

            // Online
            /*var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
            if (response.IsSuccessStatusCode)
            {
                VacationList = await response.Content.ReadFromJsonAsync<List<Vacation>>();
            }*/

            // Offline
            using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            VacationList = JsonSerializer.Deserialize<List<Vacation>>(contents);

            return VacationList;
        }
    }

}

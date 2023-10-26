using Portal_Empleos_ESFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portal_Empleos_ESFE.Service.Software
{
    internal class SoftwareService : ISoftwareService
    {
        const string URL = "https://portal-empleo-api.onrender.com/empleoSoftware";

        public async Task<List<SoftwareModel>> Get()
        {
            var httpClient = new HttpClient();
            var reponse = await httpClient.GetAsync(URL);
            var content = await reponse.Content.ReadAsStringAsync();
            var softwareModel = JsonSerializer.Deserialize<List<SoftwareModel>>(content);
            return softwareModel;
        }
    }
}

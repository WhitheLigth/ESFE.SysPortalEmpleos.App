using Portal_Empleos_ESFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portal_Empleos_ESFE.Service.Mercadeo
{
    internal class MercadeoService : IMercadeoService
    {
        const string URL = "https://portal-empleo-api.onrender.com/empleosMercadeo";

        public async Task<List<MercadeoModel>> Get()
        {
            var httpClient = new HttpClient();
            var reponse = await httpClient.GetAsync(URL);
            var content = await reponse.Content.ReadAsStringAsync();
            var mercadeoModel = JsonSerializer.Deserialize<List<MercadeoModel>>(content);
            return mercadeoModel;
        }
    }
}

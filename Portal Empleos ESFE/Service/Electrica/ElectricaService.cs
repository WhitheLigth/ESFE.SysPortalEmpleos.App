using Portal_Empleos_ESFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portal_Empleos_ESFE.Service.Electrica
{
    internal class ElectricaService : IElectricaService
    {
        const string URL = "https://portal-empleo-api.onrender.com/empleosElectrica";
        public async Task<List<ElectricaModel>> Get()
        {
            var httpClient = new HttpClient();
            var reponse = await httpClient.GetAsync(URL);
            var content = await reponse.Content.ReadAsStringAsync();
            var electricaModel = JsonSerializer.Deserialize<List<ElectricaModel>>(content);
            return electricaModel;
        }
    }
}

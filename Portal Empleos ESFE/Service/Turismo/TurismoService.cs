using Portal_Empleos_ESFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portal_Empleos_ESFE.Service.Turismo
{
    internal class TurismoService : ITurismoService
    {
        const string URL = "https://portal-empleo-api.onrender.com/empleosTurismo";

        public async Task<List<TurismoModel>> Get()
        {
            var httpClient = new HttpClient();
            var reponse = await httpClient.GetAsync(URL);
            var content = await reponse.Content.ReadAsStringAsync();
            var turismoModel = JsonSerializer.Deserialize<List<TurismoModel>>(content);
            return turismoModel;
        }
    }
}

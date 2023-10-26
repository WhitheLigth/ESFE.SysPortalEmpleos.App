using Portal_Empleos_ESFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Empleos_ESFE.Service.Turismo
{
    internal interface ITurismoService
    {
        public Task<List<TurismoModel>> Get();
    }
}

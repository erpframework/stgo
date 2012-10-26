using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;

namespace Services.Service
{
    interface ISalaService
    {
        List<Sala> obtenerSalas();

        List<Sala> obtenerSalasEmpresa(long idEmpresa);

    }
}

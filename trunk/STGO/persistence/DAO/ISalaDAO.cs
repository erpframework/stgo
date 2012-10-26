using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;

namespace Persistence.DAO
{
    public interface ISalaDAO
    {
        List<Sala> obtenerSalas();

        List<Sala> obtenerSalasEmpresa(long idEmpresa);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.DAO
{
    public interface IGenericDAO
    {
        bool Conectar();

        String CadenaConexion();

        bool ComenzarTransaccion();

        bool FinalizarTransaccion();

        bool CancelarTransaccion();
    }
}

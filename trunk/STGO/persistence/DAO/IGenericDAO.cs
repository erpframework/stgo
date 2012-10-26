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

        void ComenzarTransaccion();

        void FinalizarTransaccion();

        void CancelarTransaccion();
    }

    public interface IDAOBase<T>
    {

        IList<T> ObtenerTodos();

    }
}

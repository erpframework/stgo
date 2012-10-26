using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;

namespace Persistence.DAO
{
    public interface IParametroDAO
    {
        List<Parametro> getAll();
        Parametro getFindByClave(String clave);
    }
}

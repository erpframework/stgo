using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;

namespace Services.Service
{
    public interface IParametroService
    {
        public List<Parametro> getAll();

        public Parametro getFindByClave(String clave);
    }
}

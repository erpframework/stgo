using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.Service;
using business;
using Persistence.DAO;
using Persistence.DAOImpl;

namespace Services.Impl
{
    public class ParametroService:IParametroService
    {
        //esto es una aberracion pero no hay spring o algo parecido y equivalente en .NET
        private IParametroDAO parametroDAO = new ParametroDAO();
        
        public List<Parametro> getAll() {
            return parametroDAO.getAll();
        }

        public Parametro getFindByClave(String clave) {
            return parametroDAO.getFindByClave(clave);
        }
    }
}

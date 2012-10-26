using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;
using Persistence.DAO;
using Persistence.DAOImpl;
using Services.Service;

namespace Services.ServiceImpl
{
    public class SalaService:ISalaService
    {
        private ISalaDAO salaDAO = new SalaDAO();

        public List<Sala> obtenerSalas() {
            return this.salaDAO.obtenerSalas();
        }

        public List<Sala> obtenerSalasEmpresa(long idEmpresa) {
            return this.salaDAO.obtenerSalasEmpresa(idEmpresa);
        }

    }
}

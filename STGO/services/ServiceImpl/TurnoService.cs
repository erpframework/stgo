using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;
using Services.Service;
using Persistence.DAO;
namespace Services.ServiceImpl
{
    public class TurnoService:ITurnoService
    {
        private ITurnoDAO turnoDAO;

        public List<Turno> obtenerTurnosReservados(long idSala, DateTime fecha) {
            return this.turnoDAO.obtenerTurnosReservados(idSala, fecha);
        }

        public List<Turno> obtenerTurnosLibres(long idSala, DateTime fecha) { 
            //TODO: Aca viene la logica mas complicada talvez del tp que es armar la estructura de los turnos libres
            // dependiendo de los turnos ya ocupados para una sala y una fecha dada.
            return null;
        }

        public Turno obtenerTurno(long idSala, long idTurno) {
            return this.turnoDAO.obtenerTurno(idSala, idTurno);
        }

        public void reservarTurno(long idSala, String nombreReservador, String descripcion, DateTime horaInicio, DateTime horaFin) {
            //TODO: Podría lanzar excepción de turno ocupado, ver esto.
            this.turnoDAO.reservarTurno(idSala, nombreReservador, descripcion, horaInicio, horaFin);
        }

        public void eliminarTurno(long idSala, long idTurno) { 
        
        }
    }
}

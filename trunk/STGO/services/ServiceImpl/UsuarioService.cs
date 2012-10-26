using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.Service;
using Persistence.DAO;
using Persistence.DAOImpl;
using business;

namespace Services.Impl
{
    public class UsuarioService:IUsuarioService
    {
        private IUsuarioDAO usuarioDAO = new UsuarioDAO();

        public List<Usuario> getAll() {
            return this.usuarioDAO.getAll();
        }

        public Usuario getFindById(long id) {
            return this.usuarioDAO.getFindById(id);
        }

        public Usuario getFindByEmail(String email) {
            return this.usuarioDAO.getFindByEmail(email);
        }

        public Usuario saveOrUpdate(Usuario usuario) {
            return this.usuarioDAO.saveOrUpdate(usuario);
        }
    }
}

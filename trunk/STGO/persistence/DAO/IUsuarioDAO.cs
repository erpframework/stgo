using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using business;

namespace Persistence.DAO
{
    public interface IUsuarioDAO
    {
        List<Usuario> getAll();
        Usuario getFindById(long id);
        Usuario getFindByEmail(String email);
        Usuario saveOrUpdate(Usuario usuario);

    }
}

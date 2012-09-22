using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace business
{
    public class Perfil
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }

        public Perfil(int id, String descripcion) 
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}

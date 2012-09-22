﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace business
{
    public class Usuario
    {
        public long Id{ get; set; }
        public String EMail { get; set; }
        public String NombreApellido{ get; set; }
        public String Password{ get; set; }
        public Perfil Perfil { get; set; }

        public Usuario(String eMail, String password, String nombreApellido, Perfil perfil) 
        {
            this.Perfil = perfil;
            this.NombreApellido = nombreApellido;
            this.EMail = eMail;
            this.Password = password;
        }


    }
}

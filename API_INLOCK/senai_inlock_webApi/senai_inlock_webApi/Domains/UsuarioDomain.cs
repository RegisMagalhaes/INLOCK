using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webApi.Domains
{
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public int tipoUsuario { get; set; }


    }
}

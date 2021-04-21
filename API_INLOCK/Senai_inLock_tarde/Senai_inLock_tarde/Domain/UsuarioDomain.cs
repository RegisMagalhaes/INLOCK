using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Domain
{
    /// <summary>
    /// Classe que representa a entidade (Tabela) Usuario do Banco de dados do inLock.
    /// </summary>


    public class UsuarioDomain
    {
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int idTipoUsuario { get; set; }


    }
}

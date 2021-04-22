using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string email { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string senha { get; set; }
        public int idTipoUsuario { get; set; }


    }
}

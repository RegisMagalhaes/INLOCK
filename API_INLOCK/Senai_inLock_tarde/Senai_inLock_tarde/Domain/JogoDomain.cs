using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Domain
{
    /// <summary>
    /// Classe que representa a entidade (Tabela) Jogos do Banco de dados do inLock.
    /// </summary>
    
    public class JogoDomain
    {
        public int idJogo { get; set; }

        public string nomeJogo { get; set; }
        [Required(ErrorMessage ="O nome do jogo é obrigatório!")]

        public string descricao { get; set; }
        [DataType (DataType.Date)]
        public DateTime dataLancamento { get; set; }

        public double valor { get; set; }

        public int idEstudio { get; set; }
    }
}

using System;
using System.Collections.Generic;
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

        public string descricao { get; set; }

        public string dataLancamento { get; set; }

        public double valor { get; set; }

        public int idEstudio { get; set; }
    }
}

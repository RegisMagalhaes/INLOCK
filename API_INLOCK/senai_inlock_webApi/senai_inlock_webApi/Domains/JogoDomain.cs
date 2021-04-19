using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webApi.Domains
{
    public class JogoDomain
    {
        public int idJogo { get; set; }

        public string nomeJogo { get; set; }

        public string descricao { get; set; }

        public string dataLancamento { get; set; }

        public float valor { get; set; }

        public int idEstudio { get; set; }  
    }
}

using Senai_inLock_tarde.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Interface
{
    /// <summary>
    /// Interface Responsavel pelo repositório EstudioRepository
    /// </summary>[


    interface IEstudioRepository
    {
        //TipoRetorno NomeMetodo (Tipo parametro NomeParametro);

        /// <summary>
        /// Retorna todos os estudios.
        /// </summary>
        /// <return>Uma lista de Estudios</return>
        List<EstudioDomain> ListarTodos();



        /// <summary>
        /// Busca um estudio através do seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Um objeto do tipo EstudioDomain que foi buscado</returns>
        EstudioDomain BuscarPorId(int id);



        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio"></param>
        void Cadastrar(EstudioDomain novoEstudio);


    }
}

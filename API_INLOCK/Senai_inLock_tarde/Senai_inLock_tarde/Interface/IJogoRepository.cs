using Senai_inLock_tarde.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Interface
{
    /// <summary>
    /// Interface responsavel pelo repositorio JogoRepository
    /// </summary>
    interface IJogoRepository
    {
        /// <summary>
        /// Retorna todos os Jogos .
        /// </summary>
        /// <returns>Uma lista de Jogos</returns>
        List<JogoDomain> ListarTodos();

        /// <summary>
        /// Busca um jogo através do seu ID .
        /// </summary>
        /// <param name="id"></param>
        /// <returns>um objeto do tipo JogoDomain que foi buscado </returns>
        JogoDomain BuscarPorId(int id);



        /// <summary>
        /// Cadastra um novo Jogo.
        /// </summary>
        /// <param name="novoJogo"></param>
        void Cadastrar(JogoDomain novoJogo);
    }
}

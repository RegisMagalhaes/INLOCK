using Senai_inLock_tarde.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Interface
{

    /// <summary>
    /// Interface responsavel pelo repositorio TipoUsuario
    /// </summary>
      

    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Retorna Todos os tipos de Usuarios 
        /// </summary>
        /// <returns></returns>
        List<TipoUsuarioDomain> ListarTodos();

        /// <summary>
        /// Busca um tipo de Usuario através do seu ID .
        /// </summary>
        /// <param name="id"></param>
        /// <returns>um objeto do tipo JogoDomain que foi buscado </returns>
        JogoDomain BuscarPorId(int id);



        /// <summary>
        /// Cadastra um novo Jogo.
        /// </summary>
        /// <param name="novoUsuario"></param>
        void Cadastrar(TipoUsuarioDomain novoTipoUsuario);

    }
}

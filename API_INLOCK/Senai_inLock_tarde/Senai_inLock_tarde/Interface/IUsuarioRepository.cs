using Senai_inLock_tarde.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Interface
{
    /// <summary>
    /// Interface responsável pelo Repositorio Usuario
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Retorna todos os Usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios</returns>
        List<UsuarioDomain> ListarTodos();


        /// <summary>
        /// Busca um Usuario pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Um tipo de usario por id</returns>
        UsuarioDomain BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario"></param>
        void Cadastrar(UsuarioDomain novoUsuario);
    }

}

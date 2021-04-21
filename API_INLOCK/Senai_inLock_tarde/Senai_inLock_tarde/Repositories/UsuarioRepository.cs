using Senai_inLock_tarde.Domain;
using Senai_inLock_tarde.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// String de conexão com o Banco de Dados que recebe os parametros.
        /// 
        /// Data Source = Nome do Servidor 
        /// initial catalog = nome do banco de dados 
        /// user ID = sa; pwd = 35834520898 = faz a autenticação com o usuario do sql server passando logon e senha
        /// integrated security = true = faz a autenticação com o usuario do sistema (Windows)
        /// </summary>
        /// 
         private string stringConexao = "Data Source=DESKTOP-CRR2THJ; initial catalog=inlock_games_tarde; Id=sa; pwd=@nota1000";
        public UsuarioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioDomain novoUsuario)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

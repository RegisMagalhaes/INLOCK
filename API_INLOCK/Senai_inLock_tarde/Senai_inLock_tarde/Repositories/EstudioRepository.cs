using Senai_inLock_tarde.Domain;
using Senai_inLock_tarde.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Repositories
{
    /// <summary>
    /// Classe Responsavel pelo repositorio dos Estudios
    /// </summary>

    public class EstudioRepository : IEstudioRepository
    {
        /// <summary>
        /// String de conexão com o Banco de Dados que recebe os parametros.
        /// 
        /// Data Source = Nome do Servidor 
        /// initial catalog = nome do banco de dados 
        /// user ID = sa; pwd = 35834520898 = faz a autenticação com o usuario do sql server passando logon e senha
        /// integrated security = true = faz a autenticação com o usuario do sistema (Windows)
        /// </summary>
   
      

        public EstudioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();


        }

        public void Cadastrar(EstudioDomain novoEstudio)
        {
            throw new NotImplementedException();
        }

        public List<EstudioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

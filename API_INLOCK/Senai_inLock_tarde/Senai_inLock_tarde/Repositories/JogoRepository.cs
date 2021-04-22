using Senai_inLock_tarde.Domain;
using Senai_inLock_tarde.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_inLock_tarde.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        /// <summary>
        /// String de conexão com o Banco de Dados que recebe os parametros.
        /// 
        /// Data Source = DESKTOP-CRR2THJ 
        /// initial catalog = inlock_games_tarde
        /// user ID = sa; pwd = xxxxxxxxxxxxxx = faz a autenticação com o usuario do sql server passando logon e senha
        /// integrated security = true = faz a autenticação com o usuario do sistema (Windows)
        /// </summary>
        /// 
        private string stringConexao = "Data Source=DESKTOP-CRR2THJ; initial catalog=inlock_games_tarde; user Id=sa; pwd=@nota1000";

        /// <summary>
        /// Busca um jogo através do seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>um jogo buscado ou null caso não seja encontrado</returns>
        public JogoDomain BuscarPorId(int id)
        {
            using( SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a query a ser executada
                string querySelectByld = "SELECT idJogo, nomeJogo FROM Jogos = @ID";

                //Abre conexão com o banco de dados
                con.Open();


                //Declara o SqlDataReader rdr para receber os valores do banco de dados
                SqlDataReader rdr;


                //Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelectByld, con))
                {

                    //Passa o valor para o parâmetro @ID
                    cmd.Parameters.AddWithValue("@ID", id);


                    //Executa a query e armazena os dados do rdr
                    rdr = cmd.ExecuteReader();


                    //Verifica se o resultado da query retornou algum registro
                    if (rdr.Read())
                    {

                        //Se sim, instancia um novo objeto jogobuscado do tipo JogoDomain
                        JogoDomain jogobuscado = new JogoDomain
                        {

                            //Atribui à propriedade idJogo o valor da coluna idJogo da tabela do banco de dados
                            idJogo = Convert.ToInt32(rdr["idJogo"]),

                            //Atribui à propriedade nome o valor da coluna "nomeJogo" da tabela do banco de dados
                            nomeJogo = rdr["nomeJogo"]. ToString()
                        };

                        //Retorna o jogobuscado com os dados obtidos
                        return jogobuscado;
                    }
                    //Senão, retorna null
                    return null;

                }
            }

          
    
        }

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="novoJogo"></param>
        public void Cadastrar(JogoDomain novoJogo)
        {
            //Declara a conexão con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a query que será executada
                //insert into jogos(nomeJogo, descricao, dataLancamento, valor, idEstudio)
                //values           ('Warcraft', 'RPG batalha entre mundos', '15/05/2012', 'R$99,00', 1),
                //                ('Red Dead Redemption II', 'Jogo eletronico de ação no faroeste', '26/10/2018', 'R$120,00', 2); 
                //string queryInsert = "INSERT INTO Jogos(nome) VALUES (' " +novoJogo.nome +" ')";
                //Não usar do jeito convencional por causa do efeito Joana D'Arc
                //Além de permitir SQL injection


                //Declara a query que será executada
                string queryInsert = "INSERT INTO jogos(nomeJogo, dataLancamento) VALUES (@nomeJogo, @dataLancamento)";

                //Declara que o SqlCommand cmd passando a query que será executada e a conexão como parametros
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {

                    cmd.Parameters.AddWithValue("@nomeJogo", novoJogo.nomeJogo);
                    cmd.Parameters.AddWithValue("@dataLancamento", novoJogo.dataLancamento);
                   
                    //Abre a conexão com o banco de dados
                    con.Open();

                    //executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Lista todos os jogos
        /// </summary>
        /// <returns>uma lista de jogos</returns>
        public List<JogoDomain> ListarTodos()
        {
            //Cria uma lista de jogos on de serão armazenados os dados
            List<JogoDomain> listaJogos = new List<JogoDomain>();

            //Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a instrução a ser executada
                string querySelectAll = "SELECT idJogo, nomeJogo FROM Jogos";

                // Abre a conexão com o banco de dados
                con.Open();

                //Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    //executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //Enquanto houver registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        //Instancia um objeto jogo do tipo JogoDomain
                        JogoDomain jogo = new JogoDomain()
                        {
                            //Atribui a propriedade idJogo o valor da primeira coluna da tabela do banco de dados
                            idJogo = Convert.ToInt32(rdr[0]),

                            //Atribui à propriedade nomeJogo o valor da segunda coluna da tabela do banco de dados
                            nomeJogo = rdr[1].ToString()
                        };

                        //Adiciona o objeto jogo criado à lista de Jogos
                        listaJogos.Add(jogo);
                    }
                }

                
            }
            //Retorna a lista de jogos
            return listaJogos;
        }
    }
}

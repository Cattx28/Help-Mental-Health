using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Dados
{
    public class ModeradorRepository
    {
        public string Insert(Moderador moderador)
        {
            string resp = "";

            try
            {

                Conexao.getConnection();

                string insertSql = "INSERT INTO moderador " +
                                    "(nome, email, senha) " +
                                    "VALUES (@pNome, @pEmail, @pSenha)";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(insertSql, Conexao.SqlCon);


                SqlCmd.Parameters.AddWithValue("@pNome", moderador.nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", moderador.email);
                SqlCmd.Parameters.AddWithValue("@pSenha", moderador.senha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro MySQL ({ex.Number}): {ex.Message}");

            }
            catch (Exception ex)
            {
                resp = "Erro geral: " + ex.Message;
            }
            finally
            {
                Conexao.closeConnection();

            }
            return resp;
        }

        public string Update(Moderador moderador)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE moderador SET " +
                                    "nome = @pNome, email = @pEmail " +
                                    "WHERE idModerador = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(updateSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", moderador.id);
                SqlCmd.Parameters.AddWithValue("@pNome", moderador.nome);
                SqlCmd.Parameters.AddWithValue("@pEmail", moderador.email);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public string UpdateSenha(Moderador moderador)
        {
            string resp = "";
            try
            {
                Conexao.getConnection();

                string updateSql = "UPDATE moderador SET " +
                                    "senha = @pSenha " +
                                    "WHERE idModerador = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(updateSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", moderador.id);
                SqlCmd.Parameters.AddWithValue("@pSenha", moderador.senha);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public string Delete(int idModerador)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM moderador " +
                                    "WHERE idModerador = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idModerador);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("moderador");
            try
            {
                Conexao.getConnection();

                if (Conexao.SqlCon.State != ConnectionState.Open)
        {
            throw new InvalidOperationException("A conexão com o banco de dados não está aberta.");
        }

                String selectSql = "SELECT * from moderador";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Erro no dt: " + ex.Message);
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public DataTable getAllModerador()
        {
            DataTable DtResultado = new DataTable("mod");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from moderador " +
                                    "WHERE adm = 0";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public DataTable getAllAdm()
        {
            DataTable DtResultado = new DataTable("adm");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * from moderador " +
                                    "WHERE adm = 1";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public string TornarAdm(int idModerador)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string inativeSql = "UPDATE moderador SET " +
                                    "adm = 1 " +
                                    "WHERE idModerador = @pId";
                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(inativeSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idModerador);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return resp;
        }

        public DataTable filterById(int? pId)
        {
            DataTable DtResultado = new DataTable("moderador");
            string selectSql;
            try
            {
                Conexao.getConnection();

                if (Conexao.SqlCon.State != ConnectionState.Open)
                {
                    throw new InvalidOperationException("A conexão com o banco de dados não está aberta.");
                }

                if (pId != null)
                {
                    selectSql = "SELECT * FROM moderador " +
                                "WHERE idModerador = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM moderador";
                }

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(selectSql, Conexao.SqlCon);

                if (pId != null)
                    SqlCmd.Parameters.AddWithValue("@pId", pId);

                MySql.Data.MySqlClient.MySqlDataAdapter SqlData = new MySql.Data.MySqlClient.MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                Conexao.closeConnection();
            }
            return DtResultado;
        }

        public bool login(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                return false;
            }

            try
            {
                Conexao.getConnection();

                if (Conexao.SqlCon.State != ConnectionState.Open)
                {
                    throw new InvalidOperationException("A conexão com o banco de dados não está aberta.");
                }

                {
                    // Busca apenas o hash armazenado
                    string sql = "SELECT senha FROM moderador WHERE nome = @pLogin OR email = @pLogin";

                    string senhaHash = null;


                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexao.SqlCon);

                    cmd.Parameters.AddWithValue("@pLogin", login);

                    MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        senhaHash = reader.GetString("senha");
                    }

                    if (senhaHash != null && PasswordHasher.VerifyPassword(senha, senhaHash))
                    {
                        // Se a senha estiver correta, busque os dados do usuário
                        string usuarioSql = "SELECT idModerador, nome, email FROM moderador WHERE nome = @pLogin OR email = @pLogin";
                        cmd = new MySqlCommand(usuarioSql, Conexao.SqlCon);
                        cmd.Parameters.AddWithValue("@pLogin", login);
                        // Executa o comando para buscar os dados do usuário
                        reader.Close(); // Fecha o reader anterior antes de abrir um novo
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Usuário encontrado, armazena os dados
                            UsuarioLogado.Id = reader.GetInt32("idModerador"); 
                            UsuarioLogado.Nome = reader.GetString("nome"); 
                            UsuarioLogado.Email = reader.GetString("email");
                        }
                        return true; // Login bem-sucedido
                    }
                    return false; // Login falhou
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no login: " + ex.Message);
                return false;
            }
            finally
            {
                Conexao.closeConnection(); // Certifique-se de fechar a conexão
            }
        }

    
        public bool adm(int adm)
        {
            if (adm == 0) { return false; }
            return true;
        }
    }
}

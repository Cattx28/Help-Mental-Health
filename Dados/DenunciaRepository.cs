using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class DenunciaRepository
    {
        public string DeleteMensagem(int idMensagem)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM Mensagem " +
                                    "WHERE idMensagem = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idMensagem);

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
        public string DeleteResposta(int idResposta)
        {
            string resp = " ";

            try
            {
                Conexao.getConnection();

                string deleteSql = "DELETE FROM Resposta " +
                                    "WHERE idResposta = @pId ";

                MySql.Data.MySqlClient.MySqlCommand SqlCmd = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, Conexao.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pId", idResposta);

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
        public DataTable getAllMensagem()
        {
            DataTable DtResultado = new DataTable("mensagem");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT idConversaDefinitiva, usuario, psicologo, denuncia_do_usuario " +
                                    "FROM ConversaDefinitiva " +
                                    "WHERE denuncia_do_usuario IS NOT NULL";

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
        public DataTable getAllResposta()
        {
            DataTable DtResultado = new DataTable("resposta");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT idConversaDefinitiva, usuario, psicologo, denuncia_do_psicologo " +
                                    "FROM ConversaDefinitiva " +
                                    "WHERE denuncia_do_psicologo IS NOT NULL";

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

        public DataTable getAllPostagens()
        {
            DataTable DtResultado = new DataTable("postagem");
            try
            {
                Conexao.getConnection();
                String selectSql = "SELECT * FROM Denuncia_Postagem " +
                                   "JOIN Postagem " +
                                   "ON Denuncia_Postagem.postagem = Postagem.idPostagem";

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

        public DataTable filterByIdMensagem(int? pId)
        {
            DataTable DtResultado = new DataTable("mensagem");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Mensagem " +
                                "WHERE idMensagem = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Mensagem";
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

        public DataTable filterByIdResposta(int? pId)
        {
            DataTable DtResultado = new DataTable("resposta");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Resposta " +
                                "WHERE idResposta = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Resposta";
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

        public DataTable filterByIdPostagem(int? pId)
        {
            DataTable DtResultado = new DataTable("postagem");
            string selectSql;
            try
            {
                Conexao.getConnection();
                if (pId != null)
                {
                    selectSql = "SELECT * FROM Postagem " +
                                "WHERE idPostagem = @pId";
                }
                else
                {
                    selectSql = "SELECT * FROM Postagem";
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
    }
}

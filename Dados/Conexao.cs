using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace Dados
{
    public class Conexao
    {
        public static string conString = ConfigurationManager.ConnectionStrings["cnStrMysql"].ConnectionString;
        public static MySqlConnection SqlCon = new MySqlConnection();

        public static void getConnection()
        {

            try
            {
                if (SqlCon.State == System.Data.ConnectionState.Closed)
                {
                    SqlCon.ConnectionString = conString;
                    SqlCon.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro de MySql: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }

        public static void closeConnection()
        {
            if (SqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCon.Close();
            }
        }
    }
}

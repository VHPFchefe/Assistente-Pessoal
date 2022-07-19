using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssistentePessoal.Extras
{
    class Db_connection
    {
        public SqlConnection con = new SqlConnection(
            new SqlConnectionStringBuilder()
            {
                DataSource = "localhost",
                InitialCatalog = "assist_proj",
                IntegratedSecurity = true,
            }.ConnectionString
        );
        private SqlDataReader reader = null;

        public bool SqlScript(string sql, string[] param_sql_nome, string[] param_nome)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            for (int i = 0; i < param_nome.Length; i++)
            {
                cmd.Parameters.AddWithValue(param_sql_nome[i], param_nome[i]);
            }

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados!\n" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public SqlParameter SqlConsulta(string sql)
        {
            try
            {
                // Criando o SqlCommand com parâmetro
                SqlCommand cmd = new SqlCommand(sql, con);

                // Executando o commando e obtendo o resultado
                reader = cmd.ExecuteReader();

                // Exibindo os registros
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}",
                        reader["Nome"],
                        reader["Email"]);
                }
            }
            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (con != null)
                {
                    con.Close();
                }
            }
            SqlParameter sqlP = new SqlParameter();
            sqlP.Value = null;
            return sqlP;
        }
    }
}

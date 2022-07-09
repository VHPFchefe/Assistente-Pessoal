using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistentePessoal.Entities
{
    public class Portfolio
    {
        public int id { get; private set; }
        public string name { get; set; }
        public double capital { get; private set; }



        public Portfolio(string name)
        {
            Db_connection db = new Db_connection();
            try
            {
                if (name.Length > 0)
                {
                    this.name = name;

                    string sql =
                        " Select " +
                        " id_portfolio as id, " +
                        " name_portfolio as name " +
                        " from portfolio where  removed = 0 " +
                        " and @name like name_portfolio ";

                    SqlCommand command = new SqlCommand(sql, db.con);
                    command.Parameters.AddWithValue("@name", this.name);
                   
                    //command.CommandType = CommandType.Text;
                    db.con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var teste = (IDataRecord)reader;
                        this.id = int.Parse(String.Format("{0}", teste[0]));
                        //MessageBox.Show(String.Format("{0}", teste[0]));
                    }
                    reader.Close();
                }
                capital = 0;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar a Carteira, o nome não está dentro dos parâmetros válidos.\n" + e.ToString());
            }
            finally
            {
                db.con.Close();
            }
        }


        public double QueryValue()
        {
            double value = 0;

            // Consulta o saldo da conta
            return value;
        }
        public void Insert()
        {
            string sql =
                    "INSERT INTO portfolio (name_portfolio, removed)" +
                    "VALUES (@name_portfolio, 0)";
            Db_connection db = new Db_connection();
            string[] p1 = { "@name_portfolio" };
            string[] p2 = { this.name };
            db.SqlScript(sql, p1, p2);
        }

    }
}

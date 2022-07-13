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

        public Portfolio() { }

        public Portfolio(int id , string name)
        {
            this.id = id;
            this.name = name;
        }

        public Portfolio(int id)
        {
            Db_connection db = new Db_connection();
            try
            {
                string sql =
                     " Select " +
                     " name_portfolio as name, " +
                     " patrimony as capital " +
                     " from portfolio where  removed = 0 " +
                     " and @id = id_portfolio ";

                SqlCommand command = new SqlCommand(sql, db.con);
                command.Parameters.AddWithValue("@id", id);

                //command.CommandType = CommandType.Text;
                db.con.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.name = String.Format("{0}", teste[0]);
                    this.capital = double.Parse(String.Format("{0}", teste[1]));
                    this.id = id;
                }
                reader.Close();

            }
            catch (Exception e)
            {
                throw new Exception( e.ToString());
            }
            finally
            {
                db.con.Close();
            }
        }

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
                        " name_portfolio as name, " +
                         " patrimony as capital " +
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
                        this.capital = double.Parse(String.Format("{0}", teste[2]));
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


        public void RegisterAdd()
        {
            Insert();
        }
        public void RegisterEdit()
        {
            Update();
        }

        public void RegisterRemoved(int id)
        {
            string sql = "update portfolio " +
                          "set removed = 1 " +
                          "where id_portfolio = @id_portfolio ";

            string[] p1 = { "@id_portfolio" };
            string[] p2 = { id.ToString() };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void Insert()
        {
            string sql =
                    "INSERT INTO portfolio (name_portfolio, removed,patrimony)" +
                    "VALUES (@name_portfolio, 0,0)";
            Db_connection db = new Db_connection();
            string[] p1 = { "@name_portfolio" };
            string[] p2 = { this.name };
            db.SqlScript(sql, p1, p2);
        }

        private void Update()
        {
            string sql =
              " update portfolio set " +
              " name_portfolio = @name_portfolio " +
              " from portfolio where removed = 0 " +
              " and @id like id_portfolio ";

            string[] p1 = { "@id", "@name_portfolio"};
            string[] p2 = { this.id.ToString(), this.name};
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }
    }
}

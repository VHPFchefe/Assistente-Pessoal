using System.Globalization;
using System;
using AssistentePessoal.Entities.Enum;
using System.Data.SqlClient;
using System.Data;
using AssistentePessoal.Extras;

namespace AssistentePessoal.Entities
{
    public class Transact
    {
        public int TransactNumber { get; private set; }
        public DateTime date = new DateTime();
        public Movimentation movimentation { get; private set; }
        public double value { get; private set; }
        public Portfolio portfolio { get; private set; }
        public string comment { get; private set; }
        public Senders sender { get; set; }

        public Transact() { }

        public Transact(int TransactNumber)
        {
            Db_connection db = new Db_connection();

            try
            {
                string sql =
                " Select " +
                " t.transact_value as value, " +
                " t.transact_comment as comment," +
                " s.sender_name as sender," +
                " t.id_transact_type as t_type," +
                " p.name_portfolio as portifolio," +
                " t.date_transact as date " +
                " from transact t  " +
                " inner join sender s on (s.id_sender = t.id_sender)" +
                " inner join portfolio p on (p.id_portfolio = t.id_portfolio)" +
                " where t.removed = 0 and @transact_number = t.transact_number ";

                SqlCommand command = new SqlCommand(sql, db.con);
                command.Parameters.AddWithValue("@transact_number", TransactNumber);

                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.value = double.Parse(String.Format("{0}", teste[0]));
                    this.comment = String.Format("{0}", teste[1]);
                    this.sender = new Senders(String.Format("{0}", teste[2]));
                    this.movimentation = (int.Parse(String.Format("{0}", teste[3])) == 1 ? Movimentation.Entrada : Movimentation.Saída);
                    this.portfolio = new Portfolio(String.Format("{0}", teste[4]));
                    this.date = DateTime.Parse(String.Format("{0}", teste[5]));
                    this.TransactNumber = TransactNumber;
                }
                reader.Close();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
        }

        public Transact(DateTime date, Movimentation movimentation, double value, string portfolio_name, string comment, string sender_name)
        {
            this.date = date;
            this.movimentation = movimentation;
            this.value = value;
            this.portfolio = new Portfolio(portfolio_name);
            this.comment = comment;
            this.sender = new Senders(sender_name);
        }

        public Transact(int transact_number, DateTime date, Movimentation movimentation, double value, string portfolio, string comment, string sender) : this(date, movimentation, value, portfolio, comment, sender)
        {
            this.TransactNumber = transact_number;
        }

        public void RegisterTransactAdd()
        {
            Insert();
            GerarID();
        }

        public void RegisterTransactEdit()
        {
            Update();
        }

        public void RegisterRemoved(int item)
        {
            string sql = "update transact " +
                          "set removed = 1 " +
                          "where transact_number = @transact_number ";

            string[] p1 = { "@transact_number" };
            string[] p2 = { item.ToString() };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void Insert()
        {
            string sql = "INSERT INTO transact (removed,transact_value,transact_comment,id_sender,id_transact_type,id_portfolio,date_transact)" +
                    "VALUES (@removed,cast(@transact_value as numeric(20,2)),@transact_comment," +
                    "" +
                    " @id_sender," +
                    "" +
                    "@id_transact_type," +
                    "" +
                    "@id_portfolio," +
                    "cast(@date_transact as datetime))";

            string[] p1 = { "@removed", "@transact_value", "@transact_comment", "@id_sender", "@id_transact_type", "@id_portfolio", "@date_transact", };
            string[] p2 = { "0", this.value.ToString("F2", CultureInfo.InvariantCulture), this.comment, this.sender.id.ToString(), (this.movimentation == Movimentation.Entrada ? "1" : "2"), this.portfolio.id.ToString(), this.date.ToString("yyyy-MM-dd HH:mm:ss.fff") };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void Update()
        {
            string sql =
                " update transact set " +
                " transact_value = cast(@transact_value as numeric(20, 2)), " +
                " transact_comment = @transact_comment, " +
                " id_sender = @id_sender, " +
                " id_transact_type =  @id_transact_type, " +
                " id_portfolio = @id_portfolio," +
                " date_transact = cast(@date_transact as datetime)" +
                " from transact where transact_number = @transact_number ";
            string[] p1 = { "@transact_number", "@transact_value", "@transact_comment", "@id_sender", "@id_transact_type", "@id_portfolio", "@date_transact", };
            string[] p2 = { this.TransactNumber.ToString(), this.value.ToString("F2", CultureInfo.InvariantCulture), this.comment, this.sender.id.ToString(), (this.movimentation == Movimentation.Entrada ? "1" : "2"), this.portfolio.id.ToString(), this.date.ToString("yyyy-MM-dd HH:mm:ss.fff") };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void GerarID()
        {
            Db_connection db = new Db_connection();

            try
            {
                // Gabiarra pra pegar o último criado kkk
                string sql =
                " Select top 1" +
                " t.transact_number" +
                " from transact t  " +
                " order by transact_number desc";

                SqlCommand command = new SqlCommand(sql, db.con);

                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.TransactNumber = int.Parse(String.Format("{0}", teste[0]));
                }
                reader.Close();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
        }
    }
}

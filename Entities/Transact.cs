using System.Globalization;
using System;
using System.Windows.Forms;
using AssistentePessoal.Entities.Enum;

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

        public Transact(DateTime date, Movimentation movimentation, double value, string portfolio, string comment, string sender) 
        {
            this.date = date;
            this.movimentation = movimentation;
            this.value = value;
            this.portfolio = new Portfolio(portfolio);
            this.comment = comment;
            this.sender = new Senders(sender);
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

            Db_connection db = new Db_connection();
            string[] p1 = {"@removed", "@transact_value", "@transact_comment", "@id_sender", "@id_transact_type", "@id_portfolio", "@date_transact", };
            string[] p2 = { "0", this.value.ToString("F2", CultureInfo.InvariantCulture), this.comment, this.sender.id.ToString(), (this.movimentation == Movimentation.Entrada ? "1": "2") , this.portfolio.id.ToString(), this.date.ToString("yyyy-MM-dd HH:mm:ss.fff")};
      
            db.SqlInsert(sql, p1, p2);
        }

        public void RegisterTransactAdd()
        {
            Insert();
        }

        public void RegisterTransactRemove()
        {
            //futuro update para setar a coluna removed = 1.
        }
    }
}

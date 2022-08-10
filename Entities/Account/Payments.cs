using AssistentePessoal.Extras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace AssistentePessoal.Entities.Account
{
    class Payments
    {
        public int id_payment { get; private set; }
        public string payment_name { get; set; }
        public string payment_document_path { get; set; }
        public Senders sender { get; set; }
        public DateTime emission_date { get; set; }
        public List<Parcel> parcelas = new List<Parcel>();
        public double value { get; private set; }
        public double progress { get; set; }
        public string payment_description { get; set; }

        public Payments() { }

        public Payments(int id_payment)
        {
            Db_connection db = new Db_connection();
            try
            {
                string sql =
                select

                id_payment, payment_name, payment_document_path , 
	            payment_value, s.sender_name, payment_progress, payment_emission_date
                removed, payment_description
            from payments p
            inner
            join sender s on (s.id_sender = p.id_sender)

          " where t.removed = 0 and @id_payment = t.transact_number ";

                SqlCommand command = new SqlCommand(sql, db.con);
                command.Parameters.AddWithValue("@id_payment", id_payment);

                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.id_payment = id_payment;
                    this.payment_name= String.Format("{0}", teste[0]);
                    this.payment_document_path = String.Format("{0}", teste[1]);
                    this.value = double.Parse(String.Format("{0}", teste[2]));
                    this.sender = new Senders(String.Format("{0}", teste[3]));
                    this.progress= int.Parse(String.Format("{0}", teste[4]));
                    this.emission_date = DateTime.Parse(String.Format("{0}", teste[5]));
                    this.payment_description= String.Format("{0}", teste[6]);
                }
                reader.Close();
                GerarParcelas();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
        }

        public Payments(string name, string doc_path, Senders sender, DateTime emission_date)
        {
            this.payment_name = name;
            this.payment_document_path = doc_path;
            this.sender = sender;
            this.emission_date = emission_date;
        }

        public Payments(string name, string doc_path, Senders sender, DateTime emission_date, List<Parcel> parcelas)
            : this(name, doc_path, sender, emission_date)
        {
            this.parcelas = parcelas;
            foreach (Parcel item in this.parcelas)
            {
                this.value += item.value;
            }
        }

        public int ParcelasPagas()
        {
            int qtd = 0;
            foreach (Parcel item in this.parcelas)
            {
                if (item.status == Enum.PaymentStatus.Pago)
                    qtd += 1;
            }
            return qtd;
        }

        public void AddParcel(Parcel parcel)
        {
            this.value += parcel.value;
            this.parcelas.Add(parcel);
        }

        public void RemoveParcel(int parcel)
        {
            this.value -= this.parcelas[parcel].value;
            this.parcelas.RemoveAt(parcel);
        }

        public void EditarParcela(Parcel parcel, int index)
        {
            value = 0;
            this.parcelas[index] = parcel;
            foreach (Parcel p in parcelas)
            {
                value += p.value;
            }
        }

        private void gerarId()
        {
            Db_connection db = new Db_connection();

            string sql =
                   " Select p.id_payment from payments p" +
                   " inner join sender s on (s.id_sender= p.id_sender)" +
                   " where @name = p.payment_name and s.id_sender = @sender";

            SqlCommand command = new SqlCommand(sql, db.con);
            command.Parameters.AddWithValue("@name", this.payment_name);
            command.Parameters.AddWithValue("@sender", this.sender.id.ToString());

            db.con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var teste = (IDataRecord)reader;
                this.id_payment = int.Parse(String.Format("{0}", teste[0]));
            }
            reader.Close();
        }

        /*
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
                    this.movimentation = (int.Parse(String.Format("{0}", teste[3])) == 1 ? Movimentation.Entrada: Movimentation.Saída);
                    this.portfolio = new Portfolio(String.Format("{0}", teste[4]));
                    this.date = DateTime.Parse(String.Format("{0}", teste[5]));
                    this.TransactNumber = TransactNumber;
                }
                reader.Close();
            }
        */
        public void GerarParcelas()
        {

        }

        public void RegisterPaymentAdd()
        {
            Insert();
            gerarId();
            foreach (Parcel item in parcelas)
            {
                item.RegisterAdd(this.id_payment, this.sender.name);
            }
        }

        private void Insert()
        {
            string sql = "insert into payments values(@payment_name, @payment_document_path, @value, @id_sender, @parcelas, @progress, cast(@emission_date as date), 0, @payment_description)";

            string[] p1 = { "@payment_name", "@payment_document_path", "@value", "@id_sender", "@parcelas", "@progress", "@emission_date", "@payment_description" };
            string[] p2 = { this.payment_name, this.payment_document_path ?? "", this.value.ToString("F2", CultureInfo.InvariantCulture), this.sender.id.ToString(), this.parcelas.Count.ToString(), this.progress.ToString(), this.emission_date.ToString("dd/MM/yyyy"), this.payment_description };
            MessageBox.Show(this.emission_date.ToString("dd/MM/yyyy"));
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace AssistentePessoal.Entities
{
    public class Senders
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string phone { get; private set; }
        public string email { get; private set; }
        public string cep { get; private set; }

        public Senders (string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    this.name = nome;
                    PegarId(nome);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao acessar o Cliente, o nome não está dentro dos parâmetros válidos.\n" + e.ToString());
            }

        }

        public Senders(string nome, string phone, string email, string cep)
        {
            try
            {
                if (nome.Length > 0)
                {
                    this.name = nome;
                    this.phone = phone;
                    this.email = email;
                    this.cep = cep;
                    PegarId(nome);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar o Cliente, o nome não está dentro dos parâmetros válidos.\n" + e.ToString());
            }
        }

        public void CadastroCliente()
        {
            string sql =
             "INSERT INTO sender (sender_name, removed, sender_phone, sender_email, sender_cep)" +
             "VALUES (@sender_name,0, @sender_phone, @sender_email, @sender_cep)";
            Db_connection db = new Db_connection();
            string[] p1 = { "@sender_name" , "@sender_phone", "@sender_email", "@sender_cep" };
            string[] p2 = { this.name, this.phone, this.email, this.cep };
            db.SqlInsert(sql, p1, p2);
        }

        private void PegarId(string nome)
        {
            Db_connection db = new Db_connection();

            try
            {
                string sql =
                " Select " +
                " id_sender as id, " +
                " sender_name as name " +
                " from sender where removed = 0 " +
                " and @name like sender_name ";

                SqlCommand command = new SqlCommand(sql, db.con);
                command.Parameters.AddWithValue("@name", this.name);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.id = int.Parse(String.Format("{0}", teste[0]));
                }
                reader.Close();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
        }
    }
}


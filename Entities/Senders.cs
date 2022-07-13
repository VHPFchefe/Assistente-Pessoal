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

        public Senders() { }
        
        public Senders(int id)
        {
            this.id = id;
            Pop(id);
        }

        public Senders(string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    this.name = nome;
                    Pop(nome);
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
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar o Cliente, o nome não está dentro dos parâmetros válidos.\n" + e.ToString());
            }
        }

        public Senders(int id, string nome, string phone, string email, string cep) : this(nome,phone, email, cep)
        {
            this.id = id;
        }

        private void Pop(string nome)
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

        private void Pop(int id)
        {
            Db_connection db = new Db_connection();

            try
            {
                string sql =
                " Select " +
                " sender_name," +
                " sender_phone," +
                " sender_email," +
                " sender_cep" +
                " from sender where removed = 0 " +
                " and @id like id_sender ";

                SqlCommand command = new SqlCommand(sql, db.con);
                command.Parameters.AddWithValue("@id", id);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    this.name = String.Format("{0}", teste[0]);
                    this.phone = String.Format("{0}", teste[1]);
                    this.email = String.Format("{0}", teste[2]);
                    this.cep = String.Format("{0}", teste[3]);
                }
                reader.Close();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
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
            string sql = "update sender " +
                          "set removed = 1 " +
                          "where id_sender = @id_sender ";

            string[] p1 = { "@id_sender" };
            string[] p2 = { id.ToString() };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void Insert()
        {
            string sql =
                            " insert into sender" +
                            " (sender_name,sender_phone,sender_email,sender_cep,removed) " +
                            " values (@sender_name,@sender_phone,@sender_email,@sender_cep,0)";

            string[] p1 = { "@sender_name", "@sender_phone", "@sender_email", "@sender_cep" };
            string[] p2 = { this.name, this.phone, this.email, this.cep };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }

        private void Update()
        {
            string sql =
              " update sender set " +
              " sender_name = @sender_name," +
              " sender_phone = @sender_phone ," +
              " sender_email = @sender_email," +
              " sender_cep = @sender_cep" +
              " from sender where removed = 0 " +
              " and @id like id_sender ";

            string[] p1 = { "@id", "@sender_name", "@sender_phone", "@sender_email", "@sender_cep" };
            string[] p2 = { this.id.ToString(), this.name, this.phone, this.email, this.cep };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }
    }
}


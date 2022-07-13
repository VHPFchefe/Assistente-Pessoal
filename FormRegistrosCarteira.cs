using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistentePessoal
{
    public partial class FormRegistrosCarteira : Form
    {
        public FormRegistrosCarteira()
        {
            InitializeComponent();
            this.grid.ClearSelection();
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroCarteira f = (FormCadastroCarteira)Application.OpenForms["FormCadastroCarteira"];
            if (f != null)
                f.BringToFront();
            else
            {
                f = new FormCadastroCarteira();
                f.Owner = this;
                f.Show();
            }
        }
        public void LoadGrid()
        {
            Db_connection db = new Db_connection();
            try
            {
                string parameterSQL = tx_pesquisa.Text;
                string sql = "select * from portfolio where removed = 0 " +
                    " --and ( " +
                    " sender_name like '%@p1%' or" +
                    " sender_phone like '%@p1%' or" +
                    " sender_email like '%@p1%' or" +
                    " sender_cep like '%@p1%'" +
                    " ) ";

                sql = sql.Replace("@p1", parameterSQL);

                db.con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, db.con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        this.grid.DataSource = dt;
                        this.grid.ReadOnly = true;
                    }
                }
                this.grid.Columns[0].Width = 250;
                this.grid.Columns[1].Width = 130;
                this.grid.Columns[2].Width = 230;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }
    }
}

using AssistentePessoal.Extras;
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
using AssistentePessoal.Entities.Account;

namespace AssistentePessoal
{
    public partial class FormCadastroPagamento : Form
    {

        Payments payment;
        private bool is_edit = false;
        string progress = "Progresso: 7/10";

        public FormCadastroPagamento(int edit_transact)
        {
            this.BringToFront();
            InitializeComponent();
            is_edit = true;
        }

        public FormCadastroPagamento()
        {
            InitializeComponent();
            is_edit = false;
            payment = new Payments();
            AddRow();
        }

        private void AddRow()
        {
            this.grid.Rows.Add(1);
        }

        private void RemoveRow()
        {
            foreach (DataGridViewRow item in this.grid.SelectedRows)
            {
                MessageBox.Show(item.Index.ToString());
                this.grid.Rows.RemoveAt(item.Index);
            }
        }

        private void LoadGrid()
        {
            Db_connection db = new Db_connection();
            try
            {
                string sql = "select t.transact_number as 'Número da Transação', t.transact_value as 'Valor da Transação', it.name_transact_type as 'Movimentação', s.sender_name as 'Remetente',	p.name_portfolio as 'Portifólio', 	t.transact_comment as 'Comentário',	format(t.date_transact, 'dd/MM/yyyy') as 'Data de Transação', t.id_transact_type as 'id_transact_type' from transact t inner join transact_type it on (it.id_transact_type = t.id_transact_type) inner join sender s on (s.id_sender = t.id_sender) inner join portfolio p on (p.id_portfolio = t.id_portfolio) where t.removed = 0 order by date_transact desc";
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
                this.grid.Columns["id_transact_type"].Visible = false;
                this.grid.Columns["Remetente"].Width = 110;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            RemoveRow();
        }
    }
}

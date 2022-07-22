using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using AssistentePessoal.Extras;
using AssistentePessoal.Entities;
namespace AssistentePessoal
{
    public partial class FormSystem : Form
    {
        public DateTime anoAtual = DateTime.Now;

        public FormSystem()
        {
            InitializeComponent();
            Import teste = new Import();
        }
        
        public void ConsultaGraficos(Chart grafico ,string sql, SeriesChartType seriesType)
        {
            Db_connection db = new Db_connection();

            try
            {
                string[] X = { "0", "0", "0", "0", "0", "0", "0" };
                double[] Y = { 0, 0, 0, 0, 0, 0, 0 };
                string[] X2 = { "0", "0", "0", "0", "0", "0", "0" };
                double[] Y2 = { 0, 0, 0, 0, 0, 0, 0 };

                Consultas consulta = new Consultas();
                db.con.Open();
                SqlCommand command1 = new SqlCommand(sql, db.con);
                command1.Parameters.AddWithValue("@id", 1);
                SqlCommand command2 = new SqlCommand(sql, db.con);
                command2.Parameters.AddWithValue("@id", 2);

                // Fonte de dados
                SqlDataReader reader = command1.ExecuteReader();
                int count_while = 0;

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    X[count_while] = String.Format("{0}", teste[0]);
                    Y[count_while] = double.Parse(String.Format("{0}", teste[1]));
                    count_while++;
                }
                reader.Close();

                reader = command2.ExecuteReader();
                count_while = 0;
                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    Y2[count_while] = double.Parse(String.Format("{0}", teste[1]));
                    count_while++;
                }
                reader.Close();

                GerarGráfico(grafico, X, Y, Y2, seriesType);
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            finally { db.con.Close(); }
        }

        public void AtualizarGrafico()
        {
            limpeza(grafico_entrada);
            limpeza(grafico_lucro);
            LoadGraficos();
        }

        void limpeza(Chart grafico) 
        {
            grafico.Legends.RemoveAt(0);
            grafico.Titles.RemoveAt(0);
            grafico.Series.RemoveAt(0);
            grafico.Series.RemoveAt(0);
        }

        void GerarGráfico(Chart grafico, string[] X, double[] Y, double[] Y2, SeriesChartType serieType)
        {
            //Gráfico
            Title title = new Title();
            title.Font = new Font("Arial", 20, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "Valores Mensais";
            grafico.Titles.Add(title);

            Legend legend = new Legend();
            grafico.Legends.Add(legend);
            grafico.Legends[0].Title = "Legenda";
            grafico.ChartAreas["ChartArea1"].AxisX.Title = "Ano de " + anoAtual.ToString("yyyy");
            grafico.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            grafico.ChartAreas["ChartArea1"].AxisY.Title = "R$";
            grafico.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            grafico.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            grafico.ChartAreas["ChartArea1"].AxisX.IsStartedFromZero = false;

            //Serie1
            grafico.Series.Add("entradas");
            grafico.Series["entradas"].ChartType = serieType;
            grafico.Series["entradas"].LegendText = "Entradas";
            grafico.Series["entradas"].BorderWidth = 4;

            //Serie2
            grafico.Series.Add("saidas");
            grafico.Series["saidas"].ChartType = serieType;
            grafico.Series["saidas"].LegendText = "Saídas";
            grafico.Series["saidas"].BorderWidth = 4;

            for (int i = 0; i < X.Length; i++)
            {
                grafico.Series["entradas"].Points.AddXY(X[i], Y[i]);
                grafico.Series["saidas"].Points.AddXY(X[i], Y2[i]);
            }
        }

        private void LoadGraficos()
        {
            ConsultaGraficos(grafico_entrada, new Consultas().sql_GraficoEntrada, SeriesChartType.Column);
            ConsultaGraficos(grafico_lucro, new Consultas().sql_GraficoEntrada, SeriesChartType.FastLine);
        }

        private void FormSystem_Load(object sender, EventArgs e)
        {
            LoadGraficos();
        }


        private void tollStripADM_Click(object sender, EventArgs e)
        {
            FormRegistrosSender f = (FormRegistrosSender)Application.OpenForms["FormRegistrosSender"];
            if (f != null)
                f.BringToFront();
            else
            {
                f = new FormRegistrosSender();
                f.Owner = this;
                f.Show();
            }
        }

        private void tollStripPORT_Click(object sender, EventArgs e)
        {
            FormRegistrosCarteira f = (FormRegistrosCarteira)Application.OpenForms["FormRegistrosCarteira"];
            if (f != null)
                f.BringToFront();
            else
            {
                f = new FormRegistrosCarteira();
                f.Owner = this;
                f.Show();
            }
        }

        private void tollStripMOV_Click(object sender, EventArgs e)
        {
            FormRegistrosMovimentacao f = (FormRegistrosMovimentacao)Application.OpenForms["FormRegistros"];
            if (f != null)
                f.BringToFront();
            else
            {
                f = new FormRegistrosMovimentacao();
                f.Owner = this;
                f.Show();
            }
        }

        private void toolStripPagamentos_Click(object sender, EventArgs e)
        {
            FormRegistrosPagamentos f = (FormRegistrosPagamentos)Application.OpenForms["FormRegistrosPagamentos"];
            if (f != null)
                f.BringToFront();
            else
            {
                f = new FormRegistrosPagamentos();
                f.Owner = this;
                f.Show();
            }
        }

        private void tollStripADM_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void tollStripADM_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}

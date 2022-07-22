using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistentePessoal.Entities;
using AssistentePessoal.Entities.Enum;
namespace AssistentePessoal.Extras
{
    public class Import
    {
        public Import() { }
        public Transact transact;

        public void CreateRegistros(string path, List<string> transacts_in_db)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    List<string> lines = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());
                    }

                    lines.RemoveAt(0);
                    lines.RemoveAt(lines.Count - 1);

                    if (Validate(transacts_in_db, lines))
                    {
                        PersistirRegistro(lines);
                    }
                }
            }
            catch (IOException e) { MessageBox.Show(e.ToString()); }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        private bool Validate(List<string> transacts_in_db, List<string> dados_import)
        {
            // A planilha não pode conter número de transações duplicados ou existente no banco, se houver, cancelar a operação sem salvar registros.
            List<string> imports = new List<string>();

            foreach (string item in dados_import)
            {
                string[] coll = item.Split(';');
                imports.Add(coll[0].ToString());
            }

            return Duplicado(imports) == false;
                   //Existente(transacts_in_db, imports) == false && 
        }

        private bool Duplicado(List<string> Z)
        {
            List<string> list_duplicatas = new List<string>();
            bool duplicados = false;
            string[] x = Z.ToArray();
            string[] y = Z.ToArray();
            int indexI = 0;
            string message_dupl = "";
            for (int i = 0; i < x.Length; i++)
            {
                int indexC = 0;
                for (int c = 0; c < y.Length; c++)
                {
                    if (indexC != indexI && x[i] == y[c])
                    {
                        duplicados = true;
                        list_duplicatas.Add(y[c]);
                    }
                    indexC++;
                }
                indexI++;
            }
            foreach (string item in list_duplicatas)
            {
                message_dupl += "\nN° Transação: " + item;
            }
            if (duplicados) MessageBox.Show($"A planilha contém {list_duplicatas.Count()} registros em duplicidade" + message_dupl);
            return duplicados;
        }

        private bool Existente(List<string> x, List<string> y)
        {
            bool existente = false;
            string[] items = y.ToArray();

            for (int i = 0; i < x.Count(); i++)
            {
                if (x.Contains(items[i]))
                {
                    MessageBox.Show($"Planilha não pode Transações existentes no banco de dados!\nErro na linha {i + 2} da Planilha!" +
                        $"\nTransação N° {items[i]}");
                    existente = true;
                }
            }
            return existente;
        }

        private void PersistirRegistro(List<string> ImportedData)
        {
            int transactNumber;
            double value;
            string portfolio_name, sender_name, comment;
            DateTime date;
            Movimentation movimentation;

            foreach (var lines in ImportedData)
            {
                string[] coll = lines.Split(';');
                transactNumber = int.Parse(coll[0].ToString());
                value = double.Parse(coll[1].ToString(), CultureInfo.InvariantCulture);
                movimentation = (Movimentation)Enum.Parse(typeof(Movimentation), (coll[2].ToString() == "ENTRADA" ? "1" : (coll[2].ToString() == "SAÍDA" ? "2" : "0")));
                sender_name = coll[3].ToString();
                portfolio_name = coll[4].ToString();
                comment = coll[5].ToString();
                date = DateTime.Parse(coll[6].ToString());

                //portfolio criar | Quando o ID for 0 é por que não tem, então criar.
                Portfolio port = new Portfolio(portfolio_name);
                //MessageBox.Show("ID do portfolio: " + port.name+ " => " + port.id.ToString());
                if (port.id == 0) port.RegisterAdd();

                //sender criar | Quando o ID for 0 é por que não tem, então criar.
                Senders senders = new Senders(sender_name);
                //MessageBox.Show("ID do remetente: " + senders.name + " => " + senders.id.ToString());
                if (senders.id == 0) senders.RegisterAdd();

                // Acessar o construtor completo igual de edição
                Transact transactPersist = new Transact(transactNumber, date, movimentation, value, port.name, comment, senders.name);
                transactPersist.RegisterTransactAdd();
            }
        }
    }
}
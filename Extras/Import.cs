using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistentePessoal.Entities;

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

                    if (Validate(transacts_in_db, lines))
                    {
                        PersistirRegistro();
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
            List<string>  imports = new List<string>();
            
            foreach (string item in dados_import)
            {
                string[] coll = item.Split(';');
                imports.Add(coll[0].ToString());
            }
            
            return Existente(transacts_in_db, imports) == false && Duplicado(imports) == false;
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
            string [] items =  y.ToArray();

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

        private void PersistirRegistro()
        {
            /*
            transact = new Transact(); // Acessar o construtor completo igual de edição
            transact.RegisterTransactAdd();
            */
        }
    }
}
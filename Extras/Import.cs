using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistentePessoal.Entities;

namespace AssistentePessoal.Extras
{
    public class Import : Transact
    {
        public Import() { }
        public Import(int TransactNumber) : base(TransactNumber)
        {

        }

        public bool Validate(int[] x, int[] y)
        {
            // Regras
            // A planilha não pode conter número de transações duplicados ou existente no banco, se houver, cancelar a operação sem salvar registros.
            // X = valores do banco
            // Y = valores da planilha
            return Existente(x, y) == false && Duplicado(y) == false;
        }

        private bool Duplicado(int[] Z)
        {
            List<int> list_duplicatas = new List<int>();
            bool duplicados = false;
            int[] x = Z;
            int[] y = Z;
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
            foreach (int item in list_duplicatas)
            {
                message_dupl += "\nN° Transação: " + item;
            }
            if (duplicados) MessageBox.Show($"A planilha contém {list_duplicatas.Count()} registros em duplicidade" + message_dupl);
            return duplicados;
        }

        private bool Existente(int[] x, int[] y)
        {
            bool existente = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x.Contains(y[i]))
                {
                    MessageBox.Show($"Planilha contém informações existentes no banco!\nJá existe o N° Transação na linha {i + 1} da Planilha!");
                    existente = true;
                }
            }
            return existente;
        }
    }
}
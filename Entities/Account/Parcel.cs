using System;
using System.Globalization;
using System.Windows.Forms;
using AssistentePessoal.Entities.Enum;
using AssistentePessoal.Extras;

namespace AssistentePessoal.Entities.Account
{
    public class Parcel
    {
        public int id { get; set; }
        public double value { get; private set; }
        public DateTime date_pagamento { get; private set; }
        public DateTime vencimento { get; private set; }
        public PaymentStatus status { get; private set; }
        public string comment { get; set; }
        public Portfolio portfolio { get; set; }
        public Transact transact { get; set; }

        public Parcel() { }

        public Parcel(int id, double value, DateTime vencimento)
        {
            this.id = id;
            this.value = value;
            this.vencimento = vencimento;
            this.status = PaymentStatus.A_Pagar;
        }

        public Parcel(int id, double value, DateTime vencimento, string comment)
        {
            this.id = id;
            this.value = value;
            this.vencimento = vencimento;
            this.status = PaymentStatus.A_Pagar;
            this.comment = comment;
        }
        public void PagarParcela()
        {
            this.status = PaymentStatus.Pago;
            this.date_pagamento = DateTime.Now;
        }

        public void PagarParcela(DateTime pagamento)
        {
            this.status = PaymentStatus.Pago;
            this.date_pagamento = pagamento;
        }

        public void PersistirTransact(string sender_name)
        {
            if (this.status == PaymentStatus.Pago)
            {
                this.transact = new Transact(this.date_pagamento, Movimentation.Saída, this.value, this.portfolio.name, this.comment, sender_name);
                this.transact.RegisterTransactAdd();
            }
        }

        public void RegisterAdd(int id_payment, string sender_name)
        {
            if (id_payment < 1) throw new Exception("Id de pagamento menor que 1");
            PersistirTransact(sender_name);
            string t_number, d_payment;
            string sql = "insert into parcel values(@ComecouParcelid_payment, @transact_number , @value, @payment_date, @venc_date, @is_pago)";
            if(this.status == PaymentStatus.A_Pagar)
            {
                t_number = "null";
                d_payment = "null";
            }
            else
            {
                t_number= this.transact.TransactNumber.ToString();
                d_payment = this.date_pagamento.ToString("dd/MM/yyyy");
            }

            string[] p1 = { "@ComecouParcelid_payment", "@transact_number", "@value", "@payment_date", "@venc_date", "@is_pago" };
            string[] p2 = { id_payment.ToString(), t_number, this.value.ToString("F2", CultureInfo.InvariantCulture), d_payment, this.vencimento.ToString("dd/MM/yyyy"), this.status.ToString() == "Pago" ? "1" : "0" };
            Db_connection db = new Db_connection();
            db.SqlScript(sql, p1, p2);
        }
    }
}

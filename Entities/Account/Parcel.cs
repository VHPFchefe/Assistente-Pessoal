using System;
using System.Windows.Forms;
using AssistentePessoal.Entities.Enum;

namespace AssistentePessoal.Entities.Account
{
    public class Parcel
    {
        public int id { get; private set; }
        public double value { get; private set; }
        public DateTime date_pagamento { get; private set; }
        public DateTime vencimento { get; private set; }
        public PaymentStatus status { get; private set; }

        public Parcel(int id, double value, DateTime data_pagamento, DateTime vencimento)
        {
            this.id = id;
            this.value = value;
            this.vencimento = vencimento;
            this.status = PaymentStatus.A_Pagar;
        }

        public void PagarParcela()
        {
            this.status = PaymentStatus.Pago;
            this.date_pagamento = DateTime.Now;
        }
    }
}

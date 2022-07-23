using System;
using AssistentePessoal.Entities.Enum;

namespace AssistentePessoal.Entities.Account
{
    class Parcel
    {
        public int id { get; private set; }
        public double value { get; private set; }
        public DateTime date_pagamento { get; private set; }
        public DateTime previsao { get; private set; }
        public DateTime vencimento { get; private set; }
        public PaymentStatus status { get; private set; }

        public Parcel(double value, DateTime data_pagamento, DateTime previsao, DateTime vencimento)
        {
            this.value = value;
            this.previsao = previsao;
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

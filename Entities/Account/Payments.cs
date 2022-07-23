using System;
using System.Collections.Generic;

namespace AssistentePessoal.Entities.Account
{
    class Payments
    {
        public int id_payment { get; private set; }
        public string payment_name { get; private set; }
        public string payment_document_path { get; private set; }
        public Senders sender { get; private set; }
        public DateTime emission_date { get; private set; }
        public List<Parcel> parcelas = new List<Parcel>();
        public double value { get; private set; }
        public double progress { get; private set; }

        public Payments() { }

        public Payments(string name, string doc_path, Senders sender, DateTime emission_date, List<Parcel> parcelas)
        {
            this.payment_name = name;
            this.payment_document_path = doc_path;
            this.sender = sender;
            this.emission_date = emission_date;
            this.parcelas = parcelas;
            foreach (Parcel item in this.parcelas)
            {
                if (item.status == Enum.PaymentStatus.A_Pagar)
                    this.value += item.value;
            }
        }
    }
}

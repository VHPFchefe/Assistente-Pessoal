using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssistentePessoal.Entities.Enum;

namespace AssistentePessoal.Entities
{
    public class Account
    {
        public string Name { get; set; }
        public List<Portfolio> portfolios = new List<Portfolio>();

        public Account() { }
        public Account(string name)
        {
            this.Name = name;
        }
    }
}

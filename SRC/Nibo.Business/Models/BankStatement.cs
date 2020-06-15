using System;
using System.Collections.Generic;
using System.Text;

namespace Nibo.Business.Models
{
   public class BankStatement : Entity
    {
        public string Name { get; set; }

        public DateTime StatementStart { get; set; }
        
        public DateTime StatementEnd { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }
        
    }
}

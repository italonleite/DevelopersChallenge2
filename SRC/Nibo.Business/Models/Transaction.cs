using Nibo.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Nibo.Business.Models
{
   public class Transaction : Entity
    {
        public Guid BankStatementId { get; set; }
       
        public EType Type { get; set; }

        public DateTime TransactionPostDate { get; set; }

        public decimal Amount { get; set; }

        public string Memo { get; set; }

        public BankStatement BankStatement { get; set; }
        
    }

    

}

using Nibo.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nibo.Business.Interfaces
{
   public interface IBankStatementService 
    {
        Task Save(BankStatement bankStatement);
        Task RemoveRecords();
        Task RemoveDuplicates(IEnumerable<Transaction> transactions);
    }
}

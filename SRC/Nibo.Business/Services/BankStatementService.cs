
using Nibo.Business.Interfaces;
using Nibo.Business.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nibo.Business.Services
{
    public class BankStatementService : IBankStatementService
    {

        
        private  IBankStatementRepository _repository { get; }

        public BankStatementService(IBankStatementRepository repository)
        {
            _repository = repository;
        }
                
        

        public List<Transaction> RemoveDuplicates(List<Transaction> transactions)
        {
            return transactions.Distinct().ToList();
        }

        public async Task Save(BankStatement bankStatement)
        {
           await _repository.Save(bankStatement);
        }

        public async Task RemoveRecords()
        {
            DirectoryInfo di = new DirectoryInfo("F:\\Projetos\\DesafioNibo\\SRC\\Nibo.App\\wwwroot\\Data\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }


            await _repository.RemoveRecords();



        }

        public Task RemoveDuplicates(IEnumerable<Transaction> transactions)
        {
            throw new NotImplementedException();
        }

       
    }



}

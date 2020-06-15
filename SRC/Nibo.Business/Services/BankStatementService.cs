
using Nibo.Business.Interfaces;
using Nibo.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nibo.Business.Services
{
    public class BankStatementService
    {

        
        public IBankStatementRepository Repository { get; }

        public BankStatementService(IBankStatementRepository repository)
        {
            Repository = repository;
        }

        public void Import(string fileName)
        {
            // check name file
           

            // load file
          

            // transform to save
           

            // save
            //Repository.Save();
        }

        public List<Transaction> GetAllTransactions()
        {
            return Repository.GetAllTransactions();

        }

        public List<Transaction> RemoveDuplicates(List<Transaction> transactions)
        {
            return transactions.Distinct().ToList();
        }
        
        

    }



}

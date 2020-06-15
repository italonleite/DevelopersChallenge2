using Nibo.Business.Models;
using Nibo.Business.Services;
using Nibo.Data;
using Nibo.Data.Repository;
using System.Collections.Generic;

using Xunit;

namespace Nibo.Tests
{
    public class BankStatementServiceTest
    {
        private BankStatementService service;

        public BankStatementServiceTest()
        {
            // Arrange (initialize all tests)
            // BankStatementRepository = new BankStatementRepository()
            // service = new BankStatementService(BankStatementRepository);
        }



        [Fact]
        public void ShouldImportFile()
        {
            //Arrange
            var nameFile = "extrato01.ofx";

            //Action
            service.Import(nameFile);

        }


        [Fact]
        public void GetTransactionsNotDuplicate()
        {
            //Arrange
            var transactions = service.GetAllTransactions();
            
            //Action
            var result = service.RemoveDuplicates(transactions);

            //Assert
            

        }


        [Fact]
        public void RemoveTransactionsDuplicate()
        {
            //Arrange
            var transactions = new List<Transaction>();
            transactions.Add(new Transaction() { Type = EType.Debit, Amount = 100M, Memo = "Curso de TDD", TransactionPostDate = new System.DateTime(2020, 6, 10) });
            transactions.Add(new Transaction() { Type = EType.Debit, Amount = 100M, Memo = "Curso de TDD", TransactionPostDate = new System.DateTime(2020, 6, 10) });
            transactions.Add(new Transaction() { Type = EType.Debit, Amount = 100M, Memo = "Curso de TDD", TransactionPostDate = new System.DateTime(2020, 7, 10) });
            transactions.Add(new Transaction() { Type = EType.Debit, Amount = 100M, Memo = "Curso de TDD", TransactionPostDate = new System.DateTime(2020, 8, 10) });
            transactions.Add(new Transaction() { Type = EType.Credit, Amount = 100M, Memo = "Curso de TDD", TransactionPostDate = new System.DateTime(2020, 6, 10) });


            //Action
            var result = service.RemoveDuplicates(transactions);

            //Assert
            Assert.Equal(4, result.Count);
           

        }
    }



}

using System;
using System.Collections.Generic;
using System.Text;

namespace P04_SavingsAccount
{
    public class Program
    {
        static void Main(string[] args) 
        {
            SavingsAccountOriginal firstOriginalAccount = new SavingsAccountOriginal("1232342342", 1000.50);
            firstOriginalAccount.Withdraw(210.35);
            firstOriginalAccount.ProcessFee(400.10);

            SavingsAccountOriginal secondOriginalAccount = new SavingsAccountOriginal("3434543551", 3125.40);
            secondOriginalAccount.Withdraw(50);
            secondOriginalAccount.ProcessFee(176.78);
            secondOriginalAccount.Transfer(820.16, firstOriginalAccount);
            firstOriginalAccount.Withdraw(15);

            Console.WriteLine("-----------------------After---Refactoring-----------------------");

            SavingsAccountRefactored firstRefactoredAccount = new SavingsAccountRefactored("1232342342", 1000.50);
            firstRefactoredAccount.Withdraw(210.35);
            firstRefactoredAccount.ProcessFee(400.10);

            SavingsAccountRefactored secondRefactoredAccount = new SavingsAccountRefactored("3434543551", 3125.40);
            secondRefactoredAccount.Withdraw(50);
            secondRefactoredAccount.ProcessFee(176.78);
            secondRefactoredAccount.Transfer(820.16, firstRefactoredAccount);
            firstRefactoredAccount.Withdraw(15);
        }
    }
}

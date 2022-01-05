using System;
using System.Collections.Generic;
using System.Text;

namespace P04_SavingsAccount
{
    public class SavingsAccountOriginal
    {
        private string accountNumber;

        private double balance;

        public SavingsAccountOriginal(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        private void NotifyAccountHolder(string warningMessage) 
        {
            Console.WriteLine(warningMessage);
        }

        public void Withdraw(double amountToWithdraw)
        {
            if (balance < SavingsAccountConstants.MinimumBalance)
            {
                NotifyAccountHolder(SavingsAccountConstants.WithdrawalMinimumBalanceWarning);
            }
            else 
            {
                balance -= amountToWithdraw;
                Console.WriteLine($"Balance after withdrawal of {amountToWithdraw} : {balance}");
            }
        }

        public void Transfer(double amountToTransfer, SavingsAccountOriginal recipientAccount) 
        {
            if (balance < SavingsAccountConstants.MinimumBalance)
            {
                NotifyAccountHolder(SavingsAccountConstants.TransferMinimumBalanceWarning);
            }
            else 
            {
                balance -= amountToTransfer;
                recipientAccount.balance += amountToTransfer;
                Console.WriteLine($@"The sender's balance after the transfer of {amountToTransfer} is {balance} 
                    and the balance of the addressee account is {recipientAccount.balance}");
            }
        }

        public void ProcessFee(double fee) 
        {
            balance -= fee;
            Console.WriteLine($"Balance after processing the {fee} fee : {balance} ");

            if (balance < SavingsAccountConstants.MinimumBalance) 
            {
                NotifyAccountHolder(SavingsAccountConstants.MinimumBalanceWarning);
            }
        }
    }
}

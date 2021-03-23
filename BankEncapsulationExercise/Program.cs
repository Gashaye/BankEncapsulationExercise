using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var bAccount = new BankAccount();
            bAccount.Deposit(200.5);
            Console.WriteLine(bAccount.GetBalance());
        }
    }
}

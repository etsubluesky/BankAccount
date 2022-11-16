namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount('h', 12.23M, 100, "Kay", "Kay");

            Console.WriteLine(bankAccount.FirstName);
            Console.WriteLine(bankAccount.LastName);

            bankAccount.FirstName = "New Kay";
            bankAccount.LastName = "New Kay";

            Console.WriteLine(bankAccount.FirstName);
            Console.WriteLine(bankAccount.LastName);

            Console.WriteLine(bankAccount.Deposit(12.23M));

            Console.WriteLine(bankAccount.GetBalanceAsDollars());


            Console.Write("How much money do you want to deposit? ");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());

            while(!bankAccount.Deposit(userInput))
            {
                Console.WriteLine("Please do not enter a negative number!");
                Console.Write("How much money do you want to deposit? ");
                userInput = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine(bankAccount.GetBalanceAsDollars());

            Console.WriteLine(bankAccount);

            //this is a shallow copy
            //var bankaccount2 = bankAccount;

            var bankaccount2 = new BankAccount(bankAccount);

            Console.WriteLine(bankaccount2);


            bankaccount2.Deposit(345);
            Console.WriteLine(bankAccount);
            Console.WriteLine(bankaccount2);


        }

    }
}
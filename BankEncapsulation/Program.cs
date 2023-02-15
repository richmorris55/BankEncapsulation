namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            


           BankAccount yourBankAccount = new BankAccount();



           Console.WriteLine("Please enter the amount you would like to deposit.");

           var userInput = double.Parse(Console.ReadLine());

            yourBankAccount.Deposit(userInput);

            yourBankAccount.Balance();

            Console.WriteLine("Would you like to make another deposit? Enter 1 for yes or 2 for no.");

            var userInput2 = double.Parse(Console.ReadLine());

            if (userInput2 == 1)
            {
                Console.WriteLine("Please enter the amount you would like to deposit.");

                var userInput3 = double.Parse(Console.ReadLine());

                yourBankAccount.Deposit(userInput3);

                yourBankAccount.Balance();
            }


        }
    }
}

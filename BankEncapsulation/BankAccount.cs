using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{


		}


			private double _balance = 0;

		public void Deposit(double amount)
		{

			_balance += amount;

		}


		public void Balance()
		{

			Console.WriteLine($"The new balance is {_balance} dollars.");


		}


        public void Withdraw(double amount)
        {

            _balance -= amount;

        }





    }
}







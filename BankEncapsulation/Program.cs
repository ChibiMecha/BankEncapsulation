namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(); //instance of class Bank account
            Console.WriteLine($"Welcome to HAHIR Capital. How much do you want to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine()); //user unput for amount to be accepted as a double

            ba.Deposit(amountToDeposit);//call of Deposit method to create new deposit

            double accountBalance = ba.GetBalance(); //output of Getbalance method to create new account balance

            Console.WriteLine($"Daily Available Balance: {accountBalance, 0:c}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a new public class named BankAccount
//In your BankAccount class, create the following:
//A private field of type double named **balance **with a value of 0
//Define a method named Deposit that will accept a double and store that value in the balance field
//Define a method named GetBalance that will return the amount stored in the balance field
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0; //private field

        public void Deposit(double balance) //Deposit Method - constructor to assign balance property
        {
            Console.WriteLine($"A deposit of {balance,0:c} has been made to your account.");
            _balance = balance;
        }

        public double GetBalance() //GetBalance Method
        {
            return _balance;
        }
    }
}

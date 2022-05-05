using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 5000.00f;
        float Balance;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Account holder name is {Acc_Name},Available balance is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposited Amount : ");
            float DepositAmount = Convert.ToSingle(Console.ReadLine());

            if (DepositAmount == 0)
            {
                Console.WriteLine("Deposite the minimum amount above 500.00 ");

            }
            else
            {
                Balance = Amount + DepositAmount;
                Console.WriteLine("Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void Amount_Withdrawn()
        {

            Console.WriteLine("Enter the WithDrawn Amount : ");
            float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdrawn_Amount > Balance)
            {
                throw (new WithdrawnException("Insufficent balance"));
            }
            else
            {
                Balance = Balance - Withdrawn_Amount;
                Console.WriteLine("Your Account Balance is :" + Balance + " after withdraw of "+ Withdrawn_Amount);
            }
        }     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositeAmount();
                bank.Amount_Withdrawn();

            }
            catch (WithdrawnException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Enter only numbers ", fe);
            }
            Console.Read();
        }
    }
}

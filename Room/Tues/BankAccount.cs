using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tues
{
    public class BankAccount
    {
        public int Id { get;  }
        public string Name { get; }
        public double Balance { get; set; }
        public BankAccount(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void Deposit(int val)
        {
            if (val < 0)
            {
                throw new ApplicationException("Amount can not be negative");
            }
            Balance += val;
            Console.WriteLine($"Deposit Successfull , Balance:{Balance}");
        }

        public void withdraw(int val)
        {
            if (val > Balance)
            {
                throw new ApplicationException("Insufficient Balance");
            }
            Balance -= val;
            Console.WriteLine($"Withdraw Successfull , Balance:{Balance}");
        }

        public void display()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Balance: {Balance}");
        }

    }
}

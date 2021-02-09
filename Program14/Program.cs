using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    class Program
    {
        //Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

        static void Main(string[] args)
        {
            // ---------------- RESTRICTING ACCESS TO CLASS MEMBER / FIELD ---------------------

            //NOTE: make classes and methods no more accessible than necessary!!!

            Console.WriteLine("Create a bank1 account:");

            Bank1 bank1 = new Bank1();
            bank1.InitBankAccount();
            Console.WriteLine("Balance = {0:C}", bank1.GetBalance());

            bank1.Deposit(10);

            //Wrong example:
            //Accessing the privatedata member directly will cause a compile time error

            //bank1.balance += 10;

            //Access by accessor methods
            Console.WriteLine("Balance = {0:C}", bank1.GetBalance());
            Console.WriteLine("Account Number = #{0}", bank1.GetAccountNumber());
            Console.WriteLine("Account = {0}", bank1.GetAccountInfo());

            //NOTE:
            //1. A public member is accessible to any class in the program
            //2. A private member is accessible only from the current class
            //3. A protected member is accessible from the current class and any of its subclasses
            //4. An internal member is accessible from any class within the same program module or assembly


            // ------------------------------- CLASS PROPERTY -------------------------------------

            Console.WriteLine("\nCreate a bank2 account:");

            Bank2 bank2 = new Bank2();
            bank2.InitBankAccount();
            Console.WriteLine("Balance = {0:C}", bank2.Balance);

            bank2.Deposit(20);

            //Access by class property
            Console.WriteLine("Balance = {0:C}", bank2.Balance);
            Console.WriteLine("Account Number = #{0}", bank2.AccountNumber);
            Console.WriteLine("Account Information = {0}", bank2.GetAccountInfo());


            // --------------------------------- CONSTRUCTOR --------------------------------------

            Console.WriteLine("\nCreate a bank3 account:");

            //It invokes the customized constructor automatically
            Bank3 bank3 = new Bank3();
            Console.WriteLine("Balance = {0:C}", bank3.Balance);

            bank3.Deposit(30);

            //Access by class property
            Console.WriteLine("Balance = {0:C}", bank3.Balance);
            Console.WriteLine("Account Number = #{0}", bank3.AccountNumber);
            Console.WriteLine("Account Information = {0}", bank3.GetAccountInfo());

            Console.WriteLine("\nCreate another bank3 account:");

            //It invokes the customized constructor (with parameter) automatically
            Bank3 bank4 = new Bank3(100);
            Console.WriteLine("Balance = {0:C}", bank4.Balance);

            bank4.Deposit(30);

            //Access by class property
            Console.WriteLine("Balance = {0:C}", bank4.Balance);
            Console.WriteLine("Account Number = #{0}", bank4.AccountNumber);
            Console.WriteLine("Account Information = {0}", bank4.GetAccountInfo());


            // ------------------------------ OBJECT INITIALIZER ----------------------------------

            Console.WriteLine("\nCreate a bank4 account:");

            //Object initializer
            Bank4 bank5 = new Bank4
            {
                Balance = 400
            };

            Console.WriteLine("Balance = {0:C}", bank5.Balance);

            bank5.Deposit(40);

            //Access by class property
            Console.WriteLine("Balance = {0:C}", bank5.Balance);
            Console.WriteLine("Account Number = #{0}", bank5.AccountNumber);
            Console.WriteLine("Account Information = {0}", bank5.GetAccountInfo());


            // ---------------------------- EXPRESSION BODIED MEMBER ---------------------------------

            Console.WriteLine("\nCreate a bank5 account:");

            //It invokes the customized constructor automatically
            Bank5 bank6 = new Bank5();
            Console.WriteLine("Balance = {0:C}", bank6.Balance);

            bank6.Deposit(50);

            //Access by class property
            Console.WriteLine("Balance = {0:C}", bank6.Balance);
            Console.WriteLine("Account Number = #{0}", bank6.AccountNumber);
            Console.WriteLine("Account Information = {0}", bank6.GetAccountInfo());


            //Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }
    }

    public class Bank1
    {
        private static int nextAccountNumber = 1000;
        private int accountNumber;
        private double balance;

        //Init(): Initialize a bank account with the next account id and a balance of 0
        public void InitBankAccount()
        {
            accountNumber = ++nextAccountNumber;
            balance = 0.0;
        }

        //GetBalance(): Return the current balance
        public double GetBalance()
        {
            return balance;
        }

        //AccountNumber(): Return the account number
        public int GetAccountNumber()
        {
            return accountNumber;
        }

        //SetAccountNumber(): Assign the account number
        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        //Deposit(): Allow only positive number
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                //Private member can be accessed within the current class
                Console.WriteLine("Depositing {0:C}", amount);

                balance += amount;
            }
        }

        //Withdraw(): Can withdraw any amount up to the balance
        public double Withdraw(double withdrawal)
        {
            //Upper limit
            if (balance <= withdrawal)
            {
                withdrawal = balance;
            }

            balance -= withdrawal;

            return withdrawal;
        }

        //GetAccountInfo(): Return the account information
        public string GetAccountInfo()
        {
            string s = String.Format("#{0} = {1:C}", GetAccountNumber(), GetBalance());
            return s;
        }
    }

    public class Bank2
    {
        private static int nextAccountNumber = 2000;
        private int accountNumber;
        private double balance;

        //Init(): Initialize a bank account with the next account id and a balance of 0
        public void InitBankAccount()
        {
            accountNumber = ++nextAccountNumber;
            balance = 0.0;
        }

        //Balance property
        public double Balance { get { return balance; } }

        //Account property
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }

        //Deposit(): Allow only positive number
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                //Private member can be accessed within the current class
                Console.WriteLine("Depositing {0:C}", amount);

                balance += amount;
            }
        }

        //Withdraw(): Can withdraw any amount up to the balance
        public double Withdraw(double withdrawal)
        {
            //Upper limit
            if (balance <= withdrawal)
            {
                withdrawal = balance;
            }

            balance -= withdrawal;

            return withdrawal;
        }

        //GetAccountInfo(): Return the account information
        public string GetAccountInfo()
        {
            string s = String.Format("#{0} = {1:C}", AccountNumber, Balance);
            return s;
        }
    }

    public class Bank3
    {
        private static int nextAccountNumber = 3000;
        private int accountNumber;
        private double balance;

        //Constructor: Initialize a bank account once the bank3 object be created 
        public Bank3()
        {
            accountNumber = ++nextAccountNumber;
            balance = 0.0;
        }

        //Constructor with parameter: Initialize a bank account once the bank3 object be created 
        public Bank3(double balance)
        {
            accountNumber = ++nextAccountNumber;
            this.balance = balance;
        }

        //Balance property
        public double Balance { get { return balance; } }

        //Account property
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }

        //Deposit(): Allow only positive number
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                //Private member can be accessed within the current class
                Console.WriteLine("Depositing {0:C}", amount);

                balance += amount;
            }
        }

        //Withdraw(): Can withdraw any amount up to the balance
        public double Withdraw(double withdrawal)
        {
            //Upper limit
            if (balance <= withdrawal)
            {
                withdrawal = balance;
            }

            balance -= withdrawal;

            return withdrawal;
        }

        //GetAccountInfo(): Return the account information
        public string GetAccountInfo()
        {
            string s = String.Format("#{0} = {1:C}", AccountNumber, Balance);
            return s;
        }
    }

    public class Bank4
    {
        private static int nextAccountNumber = 4000;

        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        //Constructor with parameter: Initialize a bank account once the bank3 object be created 
        public Bank4()
        {
            AccountNumber = ++nextAccountNumber;
        }

        //Deposit(): Allow only positive number
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                //Private member can be accessed within the current class
                Console.WriteLine("Depositing {0:C}", amount);

                Balance += amount;
            }
        }

        //Withdraw(): Can withdraw any amount up to the balance
        public double Withdraw(double withdrawal)
        {
            //Upper limit
            if (Balance <= withdrawal)
            {
                withdrawal = Balance;
            }

            Balance -= withdrawal;

            return withdrawal;
        }

        //GetAccountInfo(): Return the account information
        public string GetAccountInfo()
        {
            string s = String.Format("#{0} = {1:C}", AccountNumber, Balance);
            return s;
        }
    }

    public class Bank5
    {
        private static int nextAccountNumber = 5000;
        private int accountNumber;
        private double balance;

        //Constructor: Initialize a bank account once the bank3 object be created 
        public Bank5()
        {
            accountNumber = ++nextAccountNumber;
            balance = 0.0;
        }

        //Constructor with parameter: Initialize a bank account once the bank3 object be created 
        public Bank5(double balance)
        {
            accountNumber = ++nextAccountNumber;
            this.balance = balance;
        }

        //Balance property
        public double Balance { get => balance; }

        //Account property
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }

        //Deposit(): Allow only positive number
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                //Private member can be accessed within the current class
                Console.WriteLine("Depositing {0:C}", amount);

                balance += amount;
            }
        }

        //Withdraw(): Can withdraw any amount up to the balance
        public double Withdraw(double withdrawal)
        {
            //Upper limit
            if (balance <= withdrawal)
            {
                withdrawal = balance;
            }

            balance -= withdrawal;

            return withdrawal;
        }

        //GetAccountInfo(): Return the account information
        public string GetAccountInfo()
        {
            string s = String.Format("#{0} = {1:C}", AccountNumber, Balance);
            return s;
        }
    }
}

// See https://aka.ms/new-console-template for more information


/*
interactive simple mpesa like stk

Transactions
Users 
Balance 

-> TransactionTypes send , receive , pay  , loan
classes , interfaces , types 


-> assumptions 
Working with the database 
Classes with have a unique identifier

welcome user
ask for private information -> request for current balance
start a transactions window 
send,receive,pay 

Enum -> 

Boolean -> True, False 

Enum -> TransactionTypes {

Send
PayBill
PayTill
Receive

}

Reimburse the account 
Get the last 5 transactions
Get the balance 

Paybill Transaction 
Deducting and Incrementing Balances 
Reports

*/

using OopReview001.Classes;
using OopReview001.Enums;


namespace OopReview001
{
    class StkClass
    {
        // Transient , Single , Scoped 
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World! welcome to OopReview001");

            User simpleUser = GetInformation();
            
           //simpleUser.Balance
            
            Console.WriteLine(simpleUser.GetWelcomeMessage());

            TransactionInteraction(simpleUser);
        }

        private static void TransactionInteraction(User sender)
        {
            List<Transaction> transactions = new List<Transaction>();
            
            while (true)
            {
                Console.WriteLine("Which Transaction would you like to perform?\n 1.Send \n 2.Request Loan \n 3.pay Paybill , tillnumber \n 5.Summary  ");

                string action = Console.ReadLine();

                if (action.ToLower().Contains("send") || action.ToLower() == "1")
                {
                   transactions.Add(SendTransaction(sender));
                   
                   Console.WriteLine($"Sending Transaction Balance : {sender.Balance}");
                   
                } else if (action.ToLower() == "3" || action.ToLower().Contains("paybill"))
                {
                    transactions.Add(PayBillTransaction(sender));
                    
                    Console.WriteLine($"Paying Bill : {sender.Balance}");
                } else if (action.ToLower() == "5" || action.ToLower().Contains("summary"))
                {
                    TransactionSummary(transactions);
                }
                else
                {
                    Console.WriteLine("Still under development");
                }
                
            }
        }

        private static void TransactionSummary(List<Transaction> transactions)
        {
            Console.WriteLine("Transaction Count : "+transactions.Count);
        }

        private static Account GetAccountInfo()
        {
            Account account = new Account();
            
            Console.WriteLine("Enter paybill number: ");
            
            account.PayBill= Console.ReadLine();
            
            Console.WriteLine("Enter account number: ");
            
            account.AccountNumber = Console.ReadLine();
         
            return account;
        }

        private static Transaction PayBillTransaction(User sender)
        {
            Account account = GetAccountInfo();
            
            Console.WriteLine("Enter amount: ");
            
            string amountString = Console.ReadLine();
            
            double amount = double.Parse(amountString);
            
            if (sender.Balance < amount)
            {
                Console.WriteLine("You do not have enough money");
                throw new Exception("You do not have enough money");
            }

            
            sender.Balance -= amount;
           
            return new Transaction()
            {
                Id = 1,
                Amount = amount,
                Sender = sender,
                PayBillAccount = account,
                Type = TransactionTypes.PayBill
            };
        }

        private static Transaction PayTillTransaction(User sender)
        {
            /**
             * Type in paybill
             * Type in account_number
             * Type in amount
             * Validate aganist your balance -> payout
             * 
             */
            
            User receiver = GetInformation(false);
            
            double dAmount=0;

         
            return new Transaction()
            {
                Id = 1,
                Amount = dAmount,
                Sender = sender,
                Receiver = receiver,
                Type = TransactionTypes.PayTill
            };
        }

        private static Transaction SendTransaction(User sender)
        {
            
            //type in the phone number * amount , 
            //validate the balance aganist the amount
            
            User receiver = GetInformation(false);
            
            Console.WriteLine("How much money do you want to send?");
            
            string amount = Console.ReadLine();
            
            double dAmount = double.Parse(amount);
            
            if (sender.Balance < dAmount)
            {
                Console.WriteLine("You do not have enough money");
                throw new Exception("You do not have enough money");
            }
            
            sender.Balance -= dAmount;

            return  new Transaction()
            {
                Id = 1,
                Amount = dAmount,
                Sender = sender,
                Receiver = receiver,
                Type = TransactionTypes.Send
            };

        }

        private static User GetInformation(bool isSender=true)
        { 

            string currentUser = "User";

            if (isSender == false)
            {
                currentUser = "Receiver";
            }
            
            Console.WriteLine($"Hi {currentUser} Please enter your name");
            
            string name = Console.ReadLine();
            
            Console.WriteLine("Please also share your phone number");
            
            string phone = Console.ReadLine();

            double bal = 0;
            
            if (isSender)
            {
                Console.WriteLine("Please enter your account balance");
            
                string balance = Console.ReadLine();
            
                bal  = double.Parse(balance);
            }
          
            
            return new User
            {
                PhoneNumber = phone, 
                Name = name,
                Balance = bal
            };
        }
    }
}
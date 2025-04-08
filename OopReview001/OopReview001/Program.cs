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


*/

using OopReview001.Classes;

namespace OopReview001
{
    class StkClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World! welcome to OopReview001");

            User simpleUser = GetInformation();
            
            Console.WriteLine(simpleUser.GetWelcomeMessage());

            TransactionInteraction(simpleUser);

        }

        private static void TransactionInteraction(User sender)
        {
            List<Transaction> transactions = new List<Transaction>();
            
            while (true)
            {
                Console.WriteLine("Which Transaction would you like to perform?\n 1.Send \n 2.Request Loan \n 3.pay ");

                string action = Console.ReadLine();

                if (action.ToLower().Contains("send") || action.ToLower() == "1")
                {
                   transactions.Add(SendTransaction(sender));
                }
                else
                {
                    Console.WriteLine("Still under development");
                }
                
            }
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

            return  new Transaction()
            {
                Id = 1,
                Amount = dAmount,
                Sender = sender,
                Receiver = receiver,
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
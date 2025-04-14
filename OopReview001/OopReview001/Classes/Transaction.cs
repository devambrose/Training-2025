using OopReview001.Contracts;
using OopReview001.Enums;

namespace OopReview001.Classes;

public class Transaction : IDatabase
{
    public int Id { get;  set; }
    
    public double Amount { get;  set; }
    
    public TransactionTypes Type  { get;  set; }
    
    public User Sender { get;  set; }
    
    //by introducing a question mark mean that the Receiver can be null;
    public User? Receiver { get;  set; }
    
    public Account? PayBillAccount { get;  set; }
    
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
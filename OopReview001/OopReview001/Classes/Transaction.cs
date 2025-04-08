using OopReview001.Contracts;

namespace OopReview001.Classes;

public class Transaction : IDatabase
{
    public int Id { get;  set; }
    
    public double Amount { get;  set; }
    
    public string Type  { get;  set; }
    
    public User Sender { get;  set; }
    
    public User Receiver { get;  set; }
    
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
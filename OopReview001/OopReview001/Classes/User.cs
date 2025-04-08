namespace OopReview001.Classes;

public class User
{
    public string Name{ get; set; }
    
    public string PhoneNumber{ get; set; }
    
    public double Balance { get; set; }
    
    // hey James : phone_number welcome to 
    public override string ToString()
    {
        return $"{Name} : {PhoneNumber}";
    }

    public string GetWelcomeMessage()
    {
        return this.ToString() + " Welcome to OopReview001";
    }
}
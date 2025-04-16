using OopReview001.Classes;
using Transaction = System.Transactions.Transaction;

namespace OopReview001.Service;

public interface IBaseDatabase<T> where T : class
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}

public class BaseDatabase<T> : IBaseDatabase<T> where T : class
{
    public void Add(T entity)
    {
        
    }

    public void Update(T entity)
    {
        
    }

    public void Delete(T entity)
    {
        
    }
}


public class UserService : BaseDatabase<User>
{
    
    
}
/**
 * 30 classes  * 8 =>240 lines
 * 0.5 seconds
 * 120 seconds 2 mins
 * 
 * 40 lines of code  
 * 
 */


public class TransactionService
{
    void Create(Transaction transaction)
    {
        // adding to the database
        
        // make the database connection 
        
        // validate the items 
        
        // insert into the db 
        
        // handle the errors 
        
        // return true | false > if successful
    }

    void Update(Transaction transaction)
    {
        // update to the database
    }

    void Delete(Transaction transaction)
    {
        //delete item from database
    }
}

/*
T - Stands for Datatype or Type 

Class User 
*/
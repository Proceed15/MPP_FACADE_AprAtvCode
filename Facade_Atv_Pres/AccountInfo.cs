/// 1st Subclass

public class AccountInfo
{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.WriteLine("Checking account for " + c.Name + ".");
        return true;
    }
}

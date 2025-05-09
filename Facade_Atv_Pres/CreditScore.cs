/// 2nd Subclass

public class CreditScore
{
    public bool IsCreditScoreGood(Customer c)
    {
        Console.WriteLine("Checking " + c.Name + "'s credit score.");
        return true;
    }
}

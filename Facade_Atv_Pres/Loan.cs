/// Facade (Upper) Class

public class Loan
{
    AccountInfo accountInfo = new AccountInfo();
    LoanStatus loans = new LoanStatus();
    CreditScore creditScore = new CreditScore();

    public bool IsEligible(Customer customer, int amount)
    {
        Console.WriteLine("\n{0} has applied for a loan up to {1}. Checks will be performed, and the application will be concluded:\n",
        customer.Name, amount);

        bool eligible = true;

        // Perform loan checks and decide whether the customer can get a loan based on this:

        if (!accountInfo.HasSufficientSavings(customer, amount))
        {
            eligible = false;
        }
        else if (!loans.IsLoanStatusGood(customer))
        {
            eligible = false;
        }
        else if (!creditScore.IsCreditScoreGood(customer))
        {
            eligible = false;
        }

        return eligible;
    }
}
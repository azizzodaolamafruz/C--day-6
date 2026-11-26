// Task 4: FinTech: Базовый банковский счёт
public class SavingsAccount : BankAccount
{
    public decimal AnnualRate { get; set; }

    public SavingsAccount() { }

    public SavingsAccount(string accountNumber, decimal openingBalance, decimal annualRate)
        : base(accountNumber, openingBalance)
    {
        AnnualRate = annualRate;
    }

    // Низкая комиссия
    public override decimal CalculateMonthlyFee()
    {
        return 1m;
    }

    public override void CloseMonth()
    {
        base.CloseMonth();

        // Начисление процентов за месяц
        Balance += Balance * AnnualRate / 12;
    }
}

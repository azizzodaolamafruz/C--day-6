// Task 4: FinTech: Базовый банковский счёт
public class BusinessAccount : BankAccount
{
    public decimal MonthlyFlatFee { get; set; }

    public BusinessAccount() { }

    public BusinessAccount(string accountNumber, decimal openingBalance, decimal monthlyFlatFee)
        : base(accountNumber, openingBalance)
    {
        MonthlyFlatFee = monthlyFlatFee;
    }

    // Фиксированная комиссия
    public override decimal CalculateMonthlyFee()
    {
        return MonthlyFlatFee;
    }
}

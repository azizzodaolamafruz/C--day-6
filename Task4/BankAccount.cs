// Task 4: FinTech: Базовый банковский счёт
public abstract class BankAccount : EntityBase
{
    public string AccountNumber { get; set; } = string.Empty;
    public decimal Balance { get; protected set; }

    public BankAccount() { }

    public BankAccount(string accountNumber, decimal openingBalance)
    {
        AccountNumber = accountNumber;
        Balance = openingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма пополнения должна быть больше 0.");

        Balance += amount;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть больше 0.");

        if (amount > Balance)
            throw new InvalidOperationException("Недостаточно средств на счёте.");

        Balance -= amount;
        UpdatedAt = DateTime.UtcNow;
    }

    public abstract decimal CalculateMonthlyFee();

    // Метод-шаблон: списывает комиссию и обновляет UpdatedAt
    public virtual void CloseMonth()
    {
        Balance -= CalculateMonthlyFee();
        UpdatedAt = DateTime.UtcNow;
    }

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(AccountNumber))
            throw new ArgumentException("AccountNumber не может быть пустым.");

        if (Balance < 0)
            throw new ArgumentException("Balance не может быть отрицательным.");
    }
}

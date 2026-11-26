// Task 4: FinTech: Базовый банковский счёт
List<BankAccount> accounts = new List<BankAccount>
{
    new SavingsAccount("SA-001", 1000m, 0.06m),
    new BusinessAccount("BA-001", 5000m, 25m)
};

foreach (BankAccount a in accounts)
{
    a.Validate();
    System.Console.WriteLine($"{a.AccountNumber} ({a.GetType().Name}): начальный баланс {a.Balance:F2}");

    a.Deposit(500m);
    System.Console.WriteLine($"После пополнения на 500: {a.Balance:F2}");

    a.Withdraw(200m);
    System.Console.WriteLine($"После снятия 200: {a.Balance:F2}");

    System.Console.WriteLine($"Комиссия за месяц: {a.CalculateMonthlyFee():F2}");
    a.CloseMonth();
    System.Console.WriteLine($"После закрытия месяца: {a.Balance:F2}\n");
}

System.Console.WriteLine("=== Проверки ===");
try
{
    accounts[0].Withdraw(100000m);
}
catch (InvalidOperationException ex)
{
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    accounts[1].Deposit(-50m);
}
catch (ArgumentException ex)
{
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

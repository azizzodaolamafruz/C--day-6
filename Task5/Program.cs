// Task 5: FinTech: Платежные методы и комиссия
List<PaymentMethod> methods = new List<PaymentMethod>
{
    new CardPayment("Visa **** 1234", "Visa"),
    new EWalletPayment("Мой кошелёк", "Payeer"),
    new BankTransfer("Перевод со счёта", "Orienbank")
};

decimal amount = 100m;

foreach (PaymentMethod m in methods)
{
    m.Validate();

    decimal fee = m.CalculateFee(amount);
    decimal total = amount + fee;

    System.Console.WriteLine($"{m.DisplayName}: сумма {amount:F2}, комиссия {fee:F2}, к оплате {total:F2}");

    bool ok = m.Pay(total);
    System.Console.WriteLine($"Результат: {(ok ? "успешно" : "ошибка")}\n");
}

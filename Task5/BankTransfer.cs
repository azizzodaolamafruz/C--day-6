// Task 5: FinTech: Платежные методы и комиссия
public class BankTransfer : PaymentMethod
{
    public BankTransfer() { }

    public BankTransfer(string displayName, string provider) : base(displayName, provider)
    {
    }

    public override bool Pay(decimal amount)
    {
        if (amount <= 0)
            return false;

        System.Console.WriteLine($"[Банковский перевод] {DisplayName} ({Provider}): перевод {amount:F2} отправлен");
        System.Console.WriteLine("  Задержка: зачисление займёт 1-2 рабочих дня.");
        return true;
    }

    public override decimal CalculateFee(decimal amount)
    {
        return 0m;
    }
}

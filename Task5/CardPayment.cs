// Task 5: FinTech: Платежные методы и комиссия
public class CardPayment : PaymentMethod
{
    private decimal PercentFee = 0.02m;
    private decimal FixedFee = 0.30m;

    public CardPayment() { }

    public CardPayment(string displayName, string provider) : base(displayName, provider)
    {
    }

    public override bool Pay(decimal amount)
    {
        if (amount <= 0)
            return false;

        System.Console.WriteLine($"[Карта] {DisplayName} ({Provider}): оплачено {amount:F2}");
        return true;
    }

    public override decimal CalculateFee(decimal amount)
    {
        return amount * PercentFee + FixedFee;
    }
}

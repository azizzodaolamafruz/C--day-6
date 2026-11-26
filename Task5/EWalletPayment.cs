// Task 5: FinTech: Платежные методы и комиссия
public class EWalletPayment : PaymentMethod
{
    private decimal PercentFee = 0.01m;

    public EWalletPayment() { }

    public EWalletPayment(string displayName, string provider) : base(displayName, provider)
    {
    }

    public override bool Pay(decimal amount)
    {
        if (amount <= 0)
            return false;

        System.Console.WriteLine($"[Электронный кошелёк] {DisplayName} ({Provider}): оплачено {amount:F2}");
        return true;
    }

    public override decimal CalculateFee(decimal amount)
    {
        return amount * PercentFee;
    }
}

// Task 5: FinTech: Платежные методы и комиссия
public abstract class PaymentMethod : EntityBase
{
    public string DisplayName { get; set; } = string.Empty;
    public string Provider { get; set; } = string.Empty;

    public PaymentMethod() { }

    public PaymentMethod(string displayName, string provider)
    {
        DisplayName = displayName;
        Provider = provider;
    }

    public abstract bool Pay(decimal amount);

    // Хук: по умолчанию комиссия 0
    public virtual decimal CalculateFee(decimal amount)
    {
        return 0m;
    }

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(DisplayName))
            throw new ArgumentException("DisplayName не может быть пустым.");

        if (string.IsNullOrWhiteSpace(Provider))
            throw new ArgumentException("Provider не может быть пустым.");
    }
}

// Task 1: EdTech CRM: Базовый человек и роли
public abstract class Person : EntityBase
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    public Person() { }

    public Person(string fullName, string email, string phone)
    {
        FullName = fullName;
        Email = email;
        Phone = phone;
    }

    public abstract void Notify(string message);

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(FullName))
            throw new ArgumentException("FullName не может быть пустым.");

        if (string.IsNullOrWhiteSpace(Email) || !Email.Contains('@') || !Email.Contains('.'))
            throw new ArgumentException($"Некорректный Email: '{Email}'.");
    }

    public virtual string ShortInfo()
    {
        return $"{FullName} <{Email}>";
    }
}

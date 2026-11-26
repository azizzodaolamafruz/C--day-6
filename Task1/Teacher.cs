// Task 1: EdTech CRM: Базовый человек и роли
public class Teacher : Person
{
    public string Expertise { get; set; } = string.Empty;

    public Teacher() { }

    public Teacher(string fullName, string email, string phone, string expertise)
        : base(fullName, email, phone)
    {
        Expertise = expertise;
    }

    public override void Notify(string message)
    {
        System.Console.WriteLine($"[Сообщение преподавателю] Кому: {Email}. Уважаемый(ая) {FullName}, {message}");
    }

    public override string ShortInfo()
    {
        return $"Преподаватель: {FullName}, специализация: {Expertise}";
    }
}

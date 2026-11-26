// Task 1: EdTech CRM: Базовый человек и роли
public class Student : Person
{
    public string GroupName { get; set; } = string.Empty;

    public Student() { }

    public Student(string fullName, string email, string phone, string groupName)
        : base(fullName, email, phone)
    {
        GroupName = groupName;
    }

    public override void Notify(string message)
    {
        System.Console.WriteLine($"[Письмо студенту] Кому: {Email}. Здравствуйте, {FullName} (группа {GroupName})! {message}");
    }

    public override string ShortInfo()
    {
        return $"Студент: {FullName}, группа {GroupName}";
    }
}

// Task 1: EdTech CRM: Базовый человек и роли
List<Person> people = new List<Person>
{
    new Student("Иванов Иван", "ivanov@mail.com", "+992900000001", "CS-101"),
    new Student("Петрова Анна", "petrova@mail.com", "+992900000002", "CS-102"),
    new Teacher("Сидоров Пётр", "sidorov@school.com", "+992900000003", "C# / ООП")
};

System.Console.WriteLine("=== Validate() ===");
foreach (Person p in people)
{
    p.Validate();
    System.Console.WriteLine($"{p.FullName}: OK");
}

System.Console.WriteLine("\n=== ShortInfo() ===");
foreach (Person p in people)
{
    System.Console.WriteLine(p.ShortInfo());
}

System.Console.WriteLine("\n=== Notify() ===");
foreach (Person p in people)
{
    p.Notify("занятие переносится на завтра в 10:00.");
}

System.Console.WriteLine("\n=== Ошибка валидации ===");
try
{
    Student bad = new Student("", "not-an-email", "000", "CS-101");
    bad.Validate();
}
catch (ArgumentException ex)
{
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

people[0].Deactivate();
System.Console.WriteLine($"\n{people[0].FullName}: IsActive = {people[0].IsActive}");

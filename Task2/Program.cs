// Task 2: EdTech CRM: Курсы и форматы обучения
List<Course> courses = new List<Course>
{
    new OnlineCourse("C# Basics", 1000m, 40),
    new OfflineCourse("C# Advanced", 1000m, 60),
    new OnlineCourse("SQL", 500m, 30),
    new OfflineCourse("Algorithms", 800m, 50)
};

foreach (Course c in courses)
{
    c.Validate();
    System.Console.WriteLine($"{c.Title} ({c.GetType().Name}): базовая цена {c.BasePrice}, итоговая цена {c.CalculatePrice()}");
}

System.Console.WriteLine("\n=== Ошибка валидации ===");
try
{
    Course bad = new OnlineCourse("", 500m, 0);
    bad.Validate();
}
catch (ArgumentException ex)
{
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

// Task 2: EdTech CRM: Курсы и форматы обучения
public abstract class Course : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public int Hours { get; set; }

    public Course() { }

    public Course(string title, decimal basePrice, int hours)
    {
        Title = title;
        BasePrice = basePrice;
        Hours = hours;
    }

    public abstract decimal CalculatePrice();

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Title))
            throw new ArgumentException("Title не может быть пустым.");

        if (Hours <= 0)
            throw new ArgumentException("Hours должно быть больше 0.");
    }
}

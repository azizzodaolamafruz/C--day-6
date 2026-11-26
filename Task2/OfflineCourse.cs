// Task 2: EdTech CRM: Курсы и форматы обучения
public class OfflineCourse : Course
{
    public OfflineCourse() { }

    public OfflineCourse(string title, decimal basePrice, int hours)
        : base(title, basePrice, hours)
    {
    }

    public override decimal CalculatePrice()
    {
        return BasePrice + BasePrice * 0.15m;
    }
}

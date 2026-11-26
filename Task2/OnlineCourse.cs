// Task 2: EdTech CRM: Курсы и форматы обучения
public class OnlineCourse : Course
{
    public OnlineCourse() { }

    public OnlineCourse(string title, decimal basePrice, int hours)
        : base(title, basePrice, hours)
    {
    }

    public override decimal CalculatePrice()
    {
        return BasePrice - BasePrice * 0.10m;
    }
}

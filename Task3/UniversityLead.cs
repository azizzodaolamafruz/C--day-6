// Task 3: EdTech CRM: Заявки/лиды и конверсия
public class UniversityLead : Lead
{
    public bool StudentIdProvided { get; set; } = false;

    public UniversityLead() { }

    public UniversityLead(string source) : base(source)
    {
    }

    public override void AssignOwner(string managerName)
    {
        System.Console.WriteLine($"Студенческий лид из «{Source}»: ответственный {managerName}");
    }

    public override void MoveNextStatus()
    {
        // Правило студентов: первый шаг (New -> Contacted) только после предъявления студенческого билета
        if (Status == LeadStatus.New && !StudentIdProvided)
        {
            System.Console.WriteLine("UniversityLead: нужен студенческий билет, статус не изменён.");
            return;
        }

        base.MoveNextStatus();
    }
}

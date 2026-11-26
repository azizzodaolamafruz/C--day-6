// Task 3: EdTech CRM: Заявки/лиды и конверсия
public class SchoolLead : Lead
{
    public bool ParentConsent { get; set; } = false;

    public SchoolLead() { }

    public SchoolLead(string source) : base(source)
    {
    }

    public override void AssignOwner(string managerName)
    {
        System.Console.WriteLine($"Школьный лид из «{Source}»: ответственный {managerName}");
    }

    public override void MoveNextStatus()
    {
        // Правило школьников: в Qualified можно только с согласием родителей
        if (Status == LeadStatus.Contacted && !ParentConsent)
        {
            System.Console.WriteLine("SchoolLead: нужно согласие родителей, статус не изменён.");
            return;
        }

        base.MoveNextStatus();
    }
}

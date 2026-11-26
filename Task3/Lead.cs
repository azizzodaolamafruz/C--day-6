// Task 3: EdTech CRM: Заявки/лиды и конверсия
public abstract class Lead : EntityBase
{
    public string Source { get; set; } = string.Empty;
    public LeadStatus Status { get; protected set; } = LeadStatus.New;

    public Lead() { }

    public Lead(string source)
    {
        Source = source;
    }

    public abstract void AssignOwner(string managerName);

    public virtual void MoveNextStatus()
    {
        if (Status == LeadStatus.New)
        {
            Status = LeadStatus.Contacted;
            UpdatedAt = DateTime.UtcNow;
        }
        else if (Status == LeadStatus.Contacted)
        {
            Status = LeadStatus.Qualified;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Source))
            throw new ArgumentException("Source не может быть пустым.");
    }
}

// Task 3: EdTech CRM: Заявки/лиды и конверсия
SchoolLead schoolLead = new SchoolLead("Instagram");
UniversityLead universityLead = new UniversityLead("Website");

List<Lead> leads = new List<Lead> { schoolLead, universityLead };

foreach (Lead lead in leads)
{
    lead.Validate();
    lead.AssignOwner("Азиз");
}

System.Console.WriteLine("\n=== Условия не выполнены ===");
for (int step = 1; step <= 3; step++)
{
    System.Console.WriteLine($"-- Шаг {step} --");
    foreach (Lead lead in leads)
    {
        lead.MoveNextStatus();
        System.Console.WriteLine($"{lead.GetType().Name}: {lead.Status}");
    }
}

schoolLead.ParentConsent = true;
universityLead.StudentIdProvided = true;

System.Console.WriteLine("\n=== Условия выполнены ===");
for (int step = 1; step <= 3; step++)
{
    System.Console.WriteLine($"-- Шаг {step} --");
    foreach (Lead lead in leads)
    {
        lead.MoveNextStatus();
        System.Console.WriteLine($"{lead.GetType().Name}: {lead.Status}");
    }
}

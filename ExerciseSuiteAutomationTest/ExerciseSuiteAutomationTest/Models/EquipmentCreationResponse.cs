namespace ExerciseSuiteAutomationTest.Models;

public class EquipmentCreationResponse:BaseEquipment
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }
}
namespace ExerciseSuiteAutomationTest.Models;

public class EquipmentResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime DateCreated { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }
}
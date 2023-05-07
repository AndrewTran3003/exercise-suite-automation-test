using MediatR;

namespace ExerciseSuiteAutomationTest.Models.GetEquipmentHandler;

public class GetEquipmentByIdRequest : IRequest<GetEquipmentByIdResponse>
{
    public string EquipmentId { get; set; }
}
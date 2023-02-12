using MediatR;

namespace ExerciseSuiteAutomationTest.Models;

public class EquipmentCreationRequest:BaseEquipment, IRequest<EquipmentCreationResponse>
{

}
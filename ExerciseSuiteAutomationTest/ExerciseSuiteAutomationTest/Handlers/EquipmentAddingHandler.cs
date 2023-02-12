using ExerciseSuiteAutomationTest.Models;
using MediatR;

namespace ExerciseSuiteAutomationTest.Handlers;

public class EquipmentAddingHandler: IRequestHandler<EquipmentCreationRequest,EquipmentCreationResponse>
{
    public Task<EquipmentCreationResponse> Handle(EquipmentCreationRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
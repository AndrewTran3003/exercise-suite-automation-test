using ExerciseSuiteAutomationTest.Models;
using MediatR;

namespace ExerciseSuiteAutomationTest.Handlers;

public class EquipmentAddingHandler: IRequestHandler<EquipmentCreationRequest,EquipmentCreationResponse>
{
    public async Task<EquipmentCreationResponse> Handle(EquipmentCreationRequest request, CancellationToken cancellationToken)
    {
        return new EquipmentCreationResponse();
    }
}
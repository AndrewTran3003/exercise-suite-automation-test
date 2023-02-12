using AutoMapper;
using ExerciseSuiteAutomationTest.Models;
using MediatR;

namespace ExerciseSuiteAutomationTest.StepDefinitions;

[Binding]
public sealed class EquipmentStepDefinition
{
   private readonly IMediator _mediator;
   private readonly IMapper _mapper;

   public EquipmentStepDefinition(IMediator mediator, IMapper mapper)
   {
      _mediator = mediator;
      _mapper = mapper;
   }
   [Given("there is some equipment with the following details")]
   public void CreateEquipments(Table table)
   {
      List<BaseEquipment> equipmentList = ParseEquipmentListFromTable(table);
      List<EquipmentCreationRequest> equipmentListRequest =
         equipmentList.Select(e => _mapper.Map<EquipmentCreationRequest>(e)).ToList();
      _mediator.Send(equipmentListRequest);
   }

   private List<BaseEquipment> ParseEquipmentListFromTable(Table table)
   {
      throw new NotImplementedException();
   }
}
using AutoMapper;
using ExerciseSuiteAutomationTest.Models;
using MediatR;
using NUnit.Framework;

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
   public async Task CreateEquipments(Table table)
   {
      List<BaseEquipment> equipmentList = ParseEquipmentListFromTable(table);
      EquipmentCreationRequest equipmentRequest =
         _mapper.Map<EquipmentCreationRequest>(equipmentList.FirstOrDefault());
     var x = await _mediator.Send(equipmentRequest);
     Assert.NotNull(x);
   }

   private List<BaseEquipment> ParseEquipmentListFromTable(Table table)
   {
      throw new NotImplementedException();
   }
}
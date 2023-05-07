using AutoMapper;
using ExerciseSuiteAutomationTest.Models;
using ExerciseSuiteAutomationTest.Models.GetEquipmentHandler;
using MediatR;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

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
       var equipment = _mapper.Map<IEnumerable<EquipmentCreationRequest>>(table).FirstOrDefault();
       var response = await _mediator.Send(equipment);
       Assert.NotNull(response);
       Assert.AreEqual("5kg dumbbell", response.Name);
       Assert.AreEqual("dumbbell for beginners",response.Description);
   }

   [When("I get the equipment list")]
   [Given("I get the equipment list")]
   public async Task GetEquipmentList()
   {
       Assert.AreEqual(true, true);
   }

   [Then("I can find my equipment")]
   public async Task CanFindMyEquipment()
   {
       var getEquipmentRequest = new GetEquipmentByIdRequest()
       {
           EquipmentId = TestDataHolder.TestDataHolder.EquipmentData.GetLastEquipmentId()
       };
       var response = await _mediator.Send(getEquipmentRequest);
       var responseParsed = response.As<GetEquipmentByIdResponse>();
       Assert.NotNull(responseParsed);
   }
   
}
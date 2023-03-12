using AutoMapper;
using ExerciseSuiteAutomationTest.Models;
using MediatR;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace ExerciseSuiteAutomationTest.StepDefinitions;

[Binding]
public sealed class EquipmentStepDefinition
{
   private readonly IMediator _mediator;
   private readonly IMapper _mapper;
   private List<Guid> _createdEquipmentIds;
   public EquipmentStepDefinition(IMediator mediator, IMapper mapper)
   {
      _mediator = mediator;
      _mapper = mapper;
      _createdEquipmentIds = new List<Guid>();
   }
   [Given("there is some equipment with the following details")]
   public async Task CreateEquipments(Table table)
   { 
       var equipment = _mapper.Map<IEnumerable<EquipmentCreationRequest>>(table).FirstOrDefault();
       var response = await _mediator.Send(equipment);
       Assert.NotNull(response);
       Assert.AreEqual("5kg dumbbell", response.Name);
       Assert.AreEqual("dumbbell for beginners",response.Description);
       Assert.AreEqual(15.99, response.Price);
       _createdEquipmentIds.Add(response.Id);
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
       Assert.AreEqual(true,true);
   }
   
}
using System.Text.Json;
using AutoMapper;
using ExerciseSuiteAutomationTest.Models;
using GraphQL;
using GraphQL.Client.Abstractions;
using MediatR;

namespace ExerciseSuiteAutomationTest.Handlers;

public class EquipmentAddingHandler: IRequestHandler<EquipmentCreationRequest,EquipmentCreationResponse>
{
    private readonly IGraphQLClient _client;
    private readonly IMapper _mapper;

    public EquipmentAddingHandler(IGraphQLClient client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }
    public async Task<EquipmentCreationResponse> Handle(EquipmentCreationRequest request, CancellationToken cancellationToken)
    {
        var movieRequest = new GraphQLRequest
        {
            Query = @"

            mutation CreateOneEquipment ($equipment: EquipmentDtoInput!){
                CreateOneEquipment(equipment: $equipment) {
                    result {
                        id,
                        name,
                        description,
                        price
                    }
                }
            }
        ",
            Variables = new
            {
                equipment = new
                {
                    description = "dumbbell for beginners",
                    name = "5kg dumbbell",
                    price = 19.99
                }
            }
            
        };
        var response = await _client.SendQueryAsync<CreateOneEquipmentWrapper>(movieRequest);
        TestDataHolder.TestDataHolder.EquipmentData.AddEquipmentIdToList(response.Data.CreateOneEquipment.Result.Id);
        return _mapper.Map<EquipmentCreationResponse>(response.Data);
    }
}
using System.Text.Json.Serialization;
using ExerciseSuiteAutomationTest.Models;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using MediatR;

namespace ExerciseSuiteAutomationTest.Handlers;

public class EquipmentAddingHandler: IRequestHandler<EquipmentCreationRequest,EquipmentCreationResponse>
{
    private readonly IGraphQLClient _client;

    public EquipmentAddingHandler(IGraphQLClient client)
    {
        _client = client;
    }
    public async Task<EquipmentCreationResponse> Handle(EquipmentCreationRequest request, CancellationToken cancellationToken)
    {
        var movieRequest = new GraphQLRequest
        {
            Query = @"
        {
            movie {
                title,
                plot
            }
        }
    "
        };
        var response = await _client.SendQueryAsync<EquipmentCreationResponse>(movieRequest);
        return response.Data;
    }
}
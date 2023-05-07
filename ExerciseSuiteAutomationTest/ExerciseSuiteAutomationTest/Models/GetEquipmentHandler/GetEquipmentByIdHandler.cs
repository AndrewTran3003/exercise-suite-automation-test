using GraphQL;
using GraphQL.Client.Abstractions;
using MediatR;

namespace ExerciseSuiteAutomationTest.Models.GetEquipmentHandler;

public class GetEquipmentByIdHandler: IRequestHandler<GetEquipmentByIdRequest, GetEquipmentByIdResponse>
{

    
    private readonly IGraphQLClient _client;

    public GetEquipmentByIdHandler(IGraphQLClient client)
    {
        _client = client;
    }
    public async Task<GetEquipmentByIdResponse> Handle(GetEquipmentByIdRequest request, CancellationToken cancellationToken)
    {
        
        var movieRequest = new GraphQLRequest
        {
            Query = $@"

            {{equipment (equipmentId: ""{request.EquipmentId}"") {{
            result {{
            name,
            id
        }}
        }}
    }}
        "
        };
        var response = await _client.SendQueryAsync<GetEquipmentByIdResponse>(movieRequest);
        return response.Data;
    }
}
using ExerciseSuiteAutomationTest.Mappers;
using ExerciseSuiteAutomationTest.StepDefinitions;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;

namespace ExerciseSuiteAutomationTest;

public static class TestSetup
{
    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var services = new ServiceCollection();
        services.AddAutoMapper(typeof(EquipmentMapper));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<EquipmentStepDefinition>());
        services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient("http://localhost:5240/graphql", new NewtonsoftJsonSerializer()));
        return services;
    }
}
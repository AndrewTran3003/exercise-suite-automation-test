using ExerciseSuiteAutomationTest.Mappers;
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
        
        return services;
    }
}
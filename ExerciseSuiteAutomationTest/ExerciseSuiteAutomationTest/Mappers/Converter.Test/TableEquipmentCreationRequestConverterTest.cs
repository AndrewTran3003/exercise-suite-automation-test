using AutoMapper;
using ExerciseSuiteAutomationTest.Mappers.Converters;
using ExerciseSuiteAutomationTest.Models;
using Xunit;

namespace ExerciseSuiteAutomationTest.Mappers.Converter.Test;

public class TableEquipmentCreationRequestConverterTest
{
    [Fact]
    public void Test()
    {
        var mapperConfig = new MapperConfiguration(config =>
            config.AddMaps(typeof(EquipmentMapper)));
        var mapper = new Mapper(mapperConfig);
        Table table = new Table(new string[] { "name", "description", "price" });
        table.AddRow(new string[] {"5kg dumbbell","dumbbell for beginners","15.99"});
        
        var result = mapper.Map<IEnumerable<EquipmentCreationRequest>>(table).ToList();
        Assert.NotNull(result);
        Assert.Equal("5kg dumbbell",result[0].Name);
        Assert.Equal("dumbbell for beginners",result[0].Description);
        Assert.Equal(15.99,result[0].Price);
    }

}
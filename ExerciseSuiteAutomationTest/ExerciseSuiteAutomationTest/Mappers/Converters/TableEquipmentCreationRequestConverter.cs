using AutoMapper;
using ExerciseSuiteAutomationTest.Models;

namespace ExerciseSuiteAutomationTest.Mappers.Converters;

public class TableEquipmentCreationRequestConverter: ITypeConverter<Table,IEnumerable<EquipmentCreationRequest>>
{
    public IEnumerable<EquipmentCreationRequest> Convert(Table source, IEnumerable<EquipmentCreationRequest> destination, ResolutionContext context)
    {
        return source.Rows.Select(row => new EquipmentCreationRequest
        {
            Name = row["name"],
            Description = row["description"],
            Price = double.Parse(row["price"])
        });
    }
}
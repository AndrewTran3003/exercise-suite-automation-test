using AutoMapper;
using ExerciseSuiteAutomationTest.Mappers.Converters;
using ExerciseSuiteAutomationTest.Models;

namespace ExerciseSuiteAutomationTest.Mappers;

public class EquipmentMapper:Profile
{
    public EquipmentMapper()
    {
        CreateMap<BaseEquipment, EquipmentCreationRequest>();
        CreateMap<Table, IEnumerable<EquipmentCreationRequest>>().ConvertUsing<TableEquipmentCreationRequestConverter>();
    }
}
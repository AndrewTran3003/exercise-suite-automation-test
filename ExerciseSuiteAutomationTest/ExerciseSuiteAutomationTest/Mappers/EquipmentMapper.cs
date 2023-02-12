using AutoMapper;
using ExerciseSuiteAutomationTest.Models;

namespace ExerciseSuiteAutomationTest.Mappers;

public class EquipmentMapper:Profile
{
    public EquipmentMapper()
    {
        CreateMap<BaseEquipment, EquipmentCreationRequest>();
    }
}
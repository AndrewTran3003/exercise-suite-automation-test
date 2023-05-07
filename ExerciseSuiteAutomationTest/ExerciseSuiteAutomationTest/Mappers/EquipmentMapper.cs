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
        CreateMap<CreateOneEquipmentWrapper, EquipmentCreationResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CreateOneEquipment.Result.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CreateOneEquipment.Result.Name))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.CreateOneEquipment.Result.Description))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.CreateOneEquipment.Result.Price));
        
        
    }
}
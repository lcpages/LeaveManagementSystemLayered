using System;
using LeaveManagementSystem.Application.Models.LeaveTypes;
using AutoMapper;
using LeaveManagementSystem.Data;

namespace LeaveManagementSystem.MappingProfiles;

public class LeaveTypeAutoMapperProfile : Profile
{
    public LeaveTypeAutoMapperProfile()
    {
        CreateMap<LeaveType,LeaveTypeReadOnlyVM>()
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));

        CreateMap<LeaveTypeCreateVM, LeaveType>();

        CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
    }
}

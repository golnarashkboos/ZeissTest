using AutoMapper;
using ZeissTest.Data.Entities;

namespace ZeissTest.Business.Dto
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Machine, MachineDto>().ReverseMap();
            //CreateMap<MachineHistory, MachineHistoryDto>().ReverseMap();
            //CreateMap<MachineDto, MachineHistoryDto>().ReverseMap();
        }
    }
}

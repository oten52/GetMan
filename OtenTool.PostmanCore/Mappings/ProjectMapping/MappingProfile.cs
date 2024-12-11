using AutoMapper;
using OtenTool.PostmanCore.Dtos;
using OtenTool.PostmanCore.Models;

namespace OtenTool.PostmanCore.Mappings.ProjectMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<tProjectUserMap, ProjectViewDto>()
            .ForMember(x => x.ProjectId, x => x.MapFrom(x => x.ProjectId))
            .ForMember(x => x.ProjectName, x => x.MapFrom(x => x.tProject == null ? "" : x.tProject.ProjectName));
        }
    }
}

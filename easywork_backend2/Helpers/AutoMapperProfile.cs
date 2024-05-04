using AutoMapper;
using easywork_backend2.Dtos.Project;
using easywork_backend2.Entitys;
using easywork_backend2.Entitys.Log;

namespace easywork_backend2.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            
            ProjectMaps();
            LogMaps();

        }

        private void ProjectMaps()
        {
            
            CreateMap<ProjectDto, ProjectEntity>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectEntity>().ReverseMap();
        
        }

        private void LogMaps()
        {

            CreateMap<CreateProjectDto, LogEntity>();

        }
    }
}
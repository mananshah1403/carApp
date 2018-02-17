using AutoMapper;
using carApp.Controllers.Resources;
using carApp.Models;

namespace carApp.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
        }
    }
}
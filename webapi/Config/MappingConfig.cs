using AutoMapper;
using webapi.Dto;
using webapi.Models;

namespace webapi.Config
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}

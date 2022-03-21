using AutoMapper;
using BurakBlog.Entities.Concrete;
using BurakBlog.Entities.DataTransferObjects;

namespace BurakBlog.Mvc.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}

using AutoMapper;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Mappings
{
    public class UserProfile: Profile
    {

        public UserProfile()
        {
            CreateMap<User, UserResponseDto>();
        }
    }
}

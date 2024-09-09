using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Utilities;

namespace Bookbase.Application.Interfaces
{
    public interface IUserCreateValidator
    {
        //public Task<List<string>> Validate(CreateUserDto userDto);

        public Task<GenericResult<UserResponseDto>> Validate(CreateUserDto userDto);


    }
}

using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Application.Utilities;
using Bookbase.Application.Validators;
using Bookbase.Domain.Interfaces;

namespace Bookbase.Application.Services
{
    public class UserCreateValidator: IUserCreateValidator
    {

        private readonly IUserRepository _userRepository;

        public UserCreateValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GenericResult<UserResponseDto>> Validate(CreateUserDto userDto)
        {
            List<string> errMessages = new List<string>();
            var validator = new CreateUserDtoValidator();

            var validationResult = validator.Validate(userDto);

            //Check spelling errors
            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    errMessages.Add(error.ErrorMessage);
                }
            }

            //Check if username exists
            if (await _userRepository.GetOne(u => u.Username == userDto.Username) != null)
            {
                string msg = $"Username '{userDto.Username}' is already taken.";
                errMessages.Add(msg);
            }

            //Check if email exists
            if (await _userRepository.GetOne(u => u.Email == userDto.Email) != null)
            {
                string msg = $"Email '{userDto.Email}' is already taken.";
                errMessages.Add(msg);

            }

            if (errMessages.Any())
            {
                return GenericResult<UserResponseDto>.FailureResult(errMessages);
            }

            return GenericResult<UserResponseDto>.SuccessResult(
                    new UserResponseDto {  }
                );
        }

        //private async Task<List<string>> ValidateUserCreateDto(CreateUserDto userDto)
        //{

        //    List<string> errMessages = new List<string>();
        //    var validator = new CreateUserDtoValidator();
        //    var validationResult = validator.Validate(userDto);


        //    if (!validationResult.IsValid)
        //    {
        //        foreach (var error in validationResult.Errors)
        //        {
        //            errMessages.Add(error.ErrorMessage);
        //        }
        //    }

        //    //Check if username exists
        //    if (await _userRepository.GetOne(u => u.Username == userDto.Username) != null)
        //    {
        //        string msg = $"Username '{userDto.Username}' is already taken.";
        //        errMessages.Add(msg);
        //    }

        //    //Check if email exists
        //    if (await _userRepository.GetOne(u => u.Email == userDto.Email) != null)
        //    {
        //        string msg = $"Email '{userDto.Email}' is already taken.";
        //        errMessages.Add(msg);

        //    }

        //    return errMessages;
        //}
    }
}

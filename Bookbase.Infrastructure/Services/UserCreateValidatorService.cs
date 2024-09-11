using Bookbase.Infrastructure.Validators;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Domain.Common;

namespace Bookbase.Infrastructure.Services
{
    public class UserCreateValidatorService: IUserCreateValidatorService
    {

        private readonly IUserRepository _userRepository;

        public UserCreateValidatorService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GenericResult<User>> Validate(User userDto)
        {
            List<string> errMessages = new List<string>();
            var validator = new UserCreateValidator();

            var validationResult = validator.Validate(userDto);

            //Check data entry errors
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
                return GenericResult<User>.FailureResult(errMessages);
            }

            return GenericResult<User>.SuccessResult();
        }

  
    }
}

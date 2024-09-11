using Bookbase.Domain.Models;
using Bookbase.Domain.Common;

namespace Bookbase.Domain.Interfaces
{
    public interface IUserCreateValidatorService
    {
        public Task<GenericResult<User>> Validate(User user);

    }
}

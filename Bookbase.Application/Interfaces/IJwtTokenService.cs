using Bookbase.Domain.Models;

namespace Bookbase.Application.Interfaces
{
    public interface IJwtTokenService
    {
        public string GenerateJwtToken(User user);

    }
}

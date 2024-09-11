using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IJwtTokenService
    {
        public string GenerateJwtToken(User user);

    }
}

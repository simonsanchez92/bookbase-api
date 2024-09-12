using System.Security.Claims;

namespace Bookbase.Helpers
{
    public class UserHelper
    {
        public static int GetUserId(ClaimsPrincipal user)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                throw new UnauthorizedAccessException("Id is missing");
            }

            return Int32.Parse(userId);
        }
    }
}

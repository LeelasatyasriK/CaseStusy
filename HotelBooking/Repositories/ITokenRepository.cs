using Microsoft.AspNetCore.Identity;

namespace HotelBooking.Repositories
{
    public interface ITokenRepository
    {
       string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}

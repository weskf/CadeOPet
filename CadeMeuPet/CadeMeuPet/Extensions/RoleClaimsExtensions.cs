using CadeMeuPet.Model;
using System.Security.Claims;

namespace CadeMeuPet.Extensions
{
    public static class RoleClaimsExtensions
    {
        public static IEnumerable<Claim> GetClaims(this Account account)
        {
            var result = new List<Claim>
            {
                new (ClaimTypes.Name, account.Email),
            };
            return result;
        }
    }
}

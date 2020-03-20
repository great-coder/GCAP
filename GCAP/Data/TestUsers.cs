using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace GCAP.Data
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "123456", Username = "gcap", Password = "gcap",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Coder the Great"),
                    new Claim(JwtClaimTypes.GivenName, "Great"),
                    new Claim(JwtClaimTypes.FamilyName, "Coder"),
                    new Claim(JwtClaimTypes.Email, "badil2013@hotmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "https://great-coder.io"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': '***', 'locality': 'New York', 'postal_code': 85664, 'country': 'United States' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "NYC")
                }
            },
        };
    }
}

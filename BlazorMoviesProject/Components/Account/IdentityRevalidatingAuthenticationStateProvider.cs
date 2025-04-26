using System.Security.Claims;
using BlazorMoviesProject.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace BlazorMoviesProject.Components.Account
{
    internal sealed class IdentityRevalidatingAuthenticationStateProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IOptions<IdentityOptions> options)
        : RevalidatingServerAuthenticationStateProvider(loggerFactory)
    {
        private readonly ILogger logger = loggerFactory.CreateLogger<IdentityRevalidatingAuthenticationStateProvider>();

        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

        protected override async Task<bool> ValidateAuthenticationStateAsync(
            AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            try
            {
                // Get the user manager from a new scope to ensure it fetches fresh data
                await using var scope = scopeFactory.CreateAsyncScope();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                return await ValidateSecurityStampAsync(userManager, authenticationState.User);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "B��d podczas walidacji Security Stamp.");
                return false;
            }
        }

        private async Task<bool> ValidateSecurityStampAsync(UserManager<ApplicationUser> userManager, ClaimsPrincipal principal)
        {
            var user = await userManager.GetUserAsync(principal);
            if (user is null)
            {
                logger.LogWarning("Nie znaleziono u�ytkownika podczas walidacji Security Stamp.");
                return false;
            }
            else if (!userManager.SupportsUserSecurityStamp)
            {
                return true;
            }
            else
            {
                var principalStamp = principal.FindFirstValue(options.Value.ClaimsIdentity.SecurityStampClaimType);
                var userStamp = await userManager.GetSecurityStampAsync(user);
                if (principalStamp != userStamp)
                {
                    logger.LogWarning("Security Stamp u�ytkownika nie pasuje.");
                }
                return principalStamp == userStamp;
            }
        }
    }
}

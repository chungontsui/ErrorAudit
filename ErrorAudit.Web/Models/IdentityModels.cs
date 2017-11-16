﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ErrorAudit.DataAccess;
using System.Security.Principal;

namespace ErrorAudit.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
			// Add custom user claims here
			userIdentity.AddClaim(new Claim("OrganizationId", this.OrganizationId.ToString()));
            return userIdentity;
        }

		public int OrganizationId { get; set; }
    }

	public static class IdentityExtensions
	{
		public static string GetOrganization(this IIdentity identity)
		{
			var claim = ((ClaimsIdentity)identity).FindFirst("OrganizationId");
			return (claim != null) ? claim.Value.ToString() : string.Empty;
		}
	}

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
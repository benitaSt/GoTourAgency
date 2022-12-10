﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GoTourAgency.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            SavedSites = new List<UserSite>();
        }

        [Key]
        public override string Id { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public virtual List<UserSite> SavedSites { get; set; }
    }
}

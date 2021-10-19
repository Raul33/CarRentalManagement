﻿using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
             new ApplicationUser
             {
                 Id = "1aadfbb1-5743-4604-8dee-d90c9e0c97a5",
                 Email = "admin@localhost.com",
                 NormalizedEmail = "ADMIN@LOCALHOST.COM",
                 FirstName = "Admin",
                 LastName = "User",
                 UserName = "Admin",
                 NormalizedUserName = "ADMIN",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1")
             }
             );
        }
    }
}

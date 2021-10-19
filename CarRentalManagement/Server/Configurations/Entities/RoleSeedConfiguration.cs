using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "627670fd-6780-4ffb-9f21-73c9b7776085",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
             new IdentityRole
             {
                 Id = "869c20f4-5a21-4f87-acec-aa6fb4c68804",
                 Name = "User",
                 NormalizedName = "USER"
             }
            );
        }
    }
}

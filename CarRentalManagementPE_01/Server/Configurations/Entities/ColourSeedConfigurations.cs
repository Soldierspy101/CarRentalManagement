using CarRentalManagementPE_01.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Colors = CarRentalManagementPE_01.Shared.Domain.Colors;
namespace CarRentalManagementPE_01.Server.Configurations.Entities
{
    public class ColourSeedConfigurations : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder.HasData(
            new Colors
            {
                Id = 1,
                Name = "Black",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Colors
            {
                Id = 2,
                Name = "Blue",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}

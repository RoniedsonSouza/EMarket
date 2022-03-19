using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.Persistence.Configuration
{
    public class AspNetUserClaimsConfiguration : IEntityTypeConfiguration<AspNetUserClaims>
    {
        public void Configure(EntityTypeBuilder<AspNetUserClaims> builder)
        {
            builder.Property<int>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("int")
                   .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property<string>("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property<string>("ClaimValue")
                .HasColumnType("nvarchar(max)");

            builder.HasKey("Id");

            builder.HasIndex("UserId");
        }
    }
}

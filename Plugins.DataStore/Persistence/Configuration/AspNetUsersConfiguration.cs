using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.Persistence.Configuration
{
    public class AspNetUsersConfiguration : IEntityTypeConfiguration<AspNetUsers>
    {
        public void Configure(EntityTypeBuilder<AspNetUsers> builder)
        {
            builder.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

            builder.HasIndex("NormalizedUserName")
                .IsUnique()
                .HasDatabaseName("UserNameIndex")
                .HasFilter("[NormalizedUserName] IS NOT NULL");
        }
    }
}

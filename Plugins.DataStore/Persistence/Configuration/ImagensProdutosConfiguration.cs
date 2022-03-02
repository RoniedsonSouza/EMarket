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
    public class ImagensProdutosConfiguration : IEntityTypeConfiguration<ImagensProdutos>
    {
        public void Configure(EntityTypeBuilder<ImagensProdutos> builder)
        {
            builder.Property(x => x.Imagem)
                .HasColumnType("image")
                .IsRequired(true);
        }
    }
}

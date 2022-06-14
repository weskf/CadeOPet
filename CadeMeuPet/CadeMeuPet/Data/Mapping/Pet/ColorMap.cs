using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadeMeuPet.Data.Mapping
{
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {

            builder.ToTable("Tb_Color");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

        }
    }
}
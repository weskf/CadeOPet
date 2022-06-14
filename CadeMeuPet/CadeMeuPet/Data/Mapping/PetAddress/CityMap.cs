using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadeMeuPet.Data.Mapping.PetAddress
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder.ToTable("Tb_City");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

            builder
               .HasMany<State>(p => p.States)
               .WithOne(x => x.City)
               //.HasForeignKey<City>(f => f.StateId)
               .HasConstraintName("FK_City_States")
               .OnDelete(DeleteBehavior.Cascade);

        }

    }
}

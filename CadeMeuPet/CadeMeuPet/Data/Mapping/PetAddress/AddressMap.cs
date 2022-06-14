using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadeMeuPet.Data.Mapping.PetAddress
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {

            builder.ToTable("Tb_Address");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Street)
                .HasColumnName("Street")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

            builder.Property(x => x.Number)
                .HasColumnName("Number")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(10);

            builder.Property(x => x.Cep)
                .HasColumnName("Cep")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(10);

            builder.Property(x => x.District)
                .HasColumnName("District")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder
               .HasOne<City>(p => p.City)
               .WithOne(x => x.Address)
               .HasForeignKey<Address>(f => f.CityId)
               .HasConstraintName("FK_Address_City");
               

            //builder
            //   .HasOne<State>(p => p.State)
            //   .WithOne(x => x.Address)
            //   .HasForeignKey<Address>(f => f.StateId)
            //   .HasConstraintName("FK_Address_State");
               

        }
    }
}

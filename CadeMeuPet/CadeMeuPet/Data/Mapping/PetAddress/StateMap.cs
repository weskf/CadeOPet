using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadeMeuPet.Data.Mapping.PetAddress
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {

            builder.ToTable("Tb_State");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.UF)
                .HasColumnName("UF")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(2);

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(120);

        }
    }
}

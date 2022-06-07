using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadeMeuPet.Data.Mapping
{
    public class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {

            builder.ToTable("Pet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
            
            builder
               .HasOne<Breed>(p => p.PetBreed)
               .WithOne(x => x.Pet)
               .HasForeignKey<Pet>(f => f.BreedId)
               .HasConstraintName("FK_Pet_Breed");

            builder
              .HasOne<Color>(p => p.Color)
              .WithOne(x => x.Pet)
              .HasForeignKey<Pet>(f => f.ColorId)
              .HasConstraintName("FK_Pet_Color");

            builder
              .HasOne<Size>(p => p.Size)
              .WithOne(x => x.Pet)
              .HasForeignKey<Pet>(f => f.SizeId)
              .HasConstraintName("FK_Pet_Size");

            builder
             .HasMany<Image>(p => p.Images)
             .WithOne(x => x.Pet)
             //             .HasForeignKey<Image>(f => f.Id)
             .HasConstraintName("FK_Pet_Images");

            builder
             .HasOne<Status>(p => p.Status)
             .WithOne(x => x.Pet)
             .HasForeignKey<Pet>(f => f.StatusId)
             .HasConstraintName("FK_Pet_Status");

        }
    }
}

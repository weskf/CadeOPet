﻿// <auto-generated />
using CadeMeuPet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadeMeuPet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220619212919_IncluindoStatus")]
    partial class IncluindoStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CadeMeuPet.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR(20)")
                        .HasColumnName("CPF");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR(80)")
                        .HasColumnName("Email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR(80)")
                        .HasColumnName("FullName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR(80)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Password");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR(15)")
                        .HasColumnName("Telefone");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR(80)")
                        .HasColumnName("User");

                    b.HasKey("Id");

                    b.ToTable("Tb_Account", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Cep");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("District");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Street");

                    b.HasKey("Id");

                    b.HasIndex("CityId")
                        .IsUnique();

                    b.ToTable("Tb_Address", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Tb_Breed", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tb_City", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Tb_Color", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Base64")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("NVARCHAR(3000)")
                        .HasColumnName("Description");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Tb_Image", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR(80)")
                        .HasColumnName("Name");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("AddressId");

                    b.HasIndex("BreedId")
                        .IsUnique();

                    b.HasIndex("ColorId")
                        .IsUnique();

                    b.HasIndex("SizeId")
                        .IsUnique();

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.ToTable("Tb_Pet", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Tb_Size", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("NVARCHAR(2)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Tb_State", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR(120)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Tb_Status", (string)null);
                });

            modelBuilder.Entity("CadeMeuPet.Model.Address", b =>
                {
                    b.HasOne("CadeMeuPet.Model.City", "City")
                        .WithOne("Address")
                        .HasForeignKey("CadeMeuPet.Model.Address", "CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Address_City");

                    b.Navigation("City");
                });

            modelBuilder.Entity("CadeMeuPet.Model.Image", b =>
                {
                    b.HasOne("CadeMeuPet.Model.Pet", "Pet")
                        .WithMany("Images")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Images");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("CadeMeuPet.Model.Pet", b =>
                {
                    b.HasOne("CadeMeuPet.Model.Account", "Account")
                        .WithOne("Pet")
                        .HasForeignKey("CadeMeuPet.Model.Pet", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Account");

                    b.HasOne("CadeMeuPet.Model.Address", "oAddress")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CadeMeuPet.Model.Breed", "PetBreed")
                        .WithOne("Pet")
                        .HasForeignKey("CadeMeuPet.Model.Pet", "BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Breed");

                    b.HasOne("CadeMeuPet.Model.Color", "Color")
                        .WithOne("Pet")
                        .HasForeignKey("CadeMeuPet.Model.Pet", "ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Color");

                    b.HasOne("CadeMeuPet.Model.Size", "Size")
                        .WithOne("Pet")
                        .HasForeignKey("CadeMeuPet.Model.Pet", "SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Size");

                    b.HasOne("CadeMeuPet.Model.Status", "Status")
                        .WithOne("Pet")
                        .HasForeignKey("CadeMeuPet.Model.Pet", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pet_Status");

                    b.Navigation("Account");

                    b.Navigation("Color");

                    b.Navigation("PetBreed");

                    b.Navigation("Size");

                    b.Navigation("Status");

                    b.Navigation("oAddress");
                });

            modelBuilder.Entity("CadeMeuPet.Model.State", b =>
                {
                    b.HasOne("CadeMeuPet.Model.City", "City")
                        .WithMany("States")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_City_States");

                    b.Navigation("City");
                });

            modelBuilder.Entity("CadeMeuPet.Model.Account", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();
                });

            modelBuilder.Entity("CadeMeuPet.Model.Breed", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();
                });

            modelBuilder.Entity("CadeMeuPet.Model.City", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("States");
                });

            modelBuilder.Entity("CadeMeuPet.Model.Color", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();
                });

            modelBuilder.Entity("CadeMeuPet.Model.Pet", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("CadeMeuPet.Model.Size", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();
                });

            modelBuilder.Entity("CadeMeuPet.Model.Status", b =>
                {
                    b.Navigation("Pet")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

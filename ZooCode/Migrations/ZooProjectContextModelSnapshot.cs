﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooCode.Data;

#nullable disable

namespace ZooCode.Migrations
{
    [DbContext(typeof(ZooProjectContext))]
    partial class ZooProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ZooCode.Models.Animal", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalID"));

                    b.Property<string>("Animal_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AnimalID");

                    b.ToTable("Animal");

                    b.HasData(
                        new
                        {
                            AnimalID = 1,
                            Animalname = "Tiger"
                        },
                        new
                        {
                            AnimalID = 2,
                            Animalname = "Panda"
                        },
                        new
                        {
                            AnimalID = 3,
                            Animalname = "Eagle"
                        });
                });

            modelBuilder.Entity("ZooCode.Models.Zoo", b =>
                {
                    b.Property<int>("ZooID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZooID"));

                    b.Property<string>("Zoo_address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Zoo_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ZooID");

                    b.ToTable("Zoo");

                    b.HasData(
                        new
                        {
                            ZooID = 1,
                            Zooaddress = "Maglegaardsvej 2",
                            Zooname = "Zealand Zoo"
                        },
                        new
                        {
                            ZooID = 2,
                            Zooaddress = "Aalborg torv",
                            Zooname = "Aalborg Zoo"
                        },
                        new
                        {
                            ZooID = 3,
                            Zooaddress = "Køge Park",
                            Zooname = "Køge Fuglebur"
                        });
                });

            modelBuilder.Entity("ZooCode.Models.ZooAnimal", b =>
                {
                    b.Property<int>("ZooAnimalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZooAnimalID"));

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<int>("ZooID")
                        .HasColumnType("int");

                    b.HasKey("ZooAnimalID");

                    b.HasIndex("AnimalID");

                    b.HasIndex("ZooID");

                    b.ToTable("ZooAnimal");

                    b.HasData(
                        new
                        {
                            ZooAnimalID = 1,
                            AnimalID = 1,
                            ZooID = 1
                        },
                        new
                        {
                            ZooAnimalID = 2,
                            AnimalID = 2,
                            ZooID = 2
                        },
                        new
                        {
                            ZooAnimalID = 3,
                            AnimalID = 3,
                            ZooID = 3
                        });
                });

            modelBuilder.Entity("ZooCode.Models.ZooAnimal", b =>
                {
                    b.HasOne("ZooCode.Models.Animal", "Animal")
                        .WithMany("ZooAnimalCollection")
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooCode.Models.Zoo", "Zoo")
                        .WithMany("ZooAnimalCollection")
                        .HasForeignKey("ZooID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Zoo");
                });

            modelBuilder.Entity("ZooCode.Models.Animal", b =>
                {
                    b.Navigation("ZooAnimalCollection");
                });

            modelBuilder.Entity("ZooCode.Models.Zoo", b =>
                {
                    b.Navigation("ZooAnimalCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
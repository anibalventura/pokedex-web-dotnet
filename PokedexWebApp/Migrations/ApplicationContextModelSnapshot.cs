﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PokedexWebApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrimaryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondaryTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryTypeId");

                    b.HasIndex("RegionId");

                    b.HasIndex("SecondaryTypeId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Database.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Database.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Database.Models.Pokemon", b =>
                {
                    b.HasOne("Database.Models.Type", "PrimaryType")
                        .WithMany("PokemonsPrimary")
                        .HasForeignKey("PrimaryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Region", "Region")
                        .WithMany("Pokemons")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Type", "SecondaryType")
                        .WithMany("PokemonsSecondary")
                        .HasForeignKey("SecondaryTypeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("PrimaryType");

                    b.Navigation("Region");

                    b.Navigation("SecondaryType");
                });

            modelBuilder.Entity("Database.Models.Region", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("Database.Models.Type", b =>
                {
                    b.Navigation("PokemonsPrimary");

                    b.Navigation("PokemonsSecondary");
                });
#pragma warning restore 612, 618
        }
    }
}

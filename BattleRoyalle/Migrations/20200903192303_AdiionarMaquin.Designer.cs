﻿// <auto-generated />
using BattleRoyalle.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BattleRoyalle.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200903192303_AdiionarMaquin")]
    partial class AdiionarMaquin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BattleRoyalle.Models.Maquina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AntiVirus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FireWall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMaquina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TamanhoHDDisponivel")
                        .HasColumnType("real");

                    b.Property<float>("TamanhoHDTotal")
                        .HasColumnType("real");

                    b.Property<string>("VersaoNet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoWindows")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maquina");
                });
#pragma warning restore 612, 618
        }
    }
}
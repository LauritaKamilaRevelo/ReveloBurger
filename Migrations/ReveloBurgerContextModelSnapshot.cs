﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ReveloBurger.Migrations
{
    [DbContext(typeof(ReveloBurgerContext))]
    partial class ReveloBurgerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReveloBurger.Models.Burger", b =>
                {
                    b.Property<int>("BurgerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BurgerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("BurgerId");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("ReveloBurger.Models.Promo", b =>
                {
                    b.Property<int>("PromoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromoId"));

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<string>("Descipcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPromo")
                        .HasColumnType("datetime2");

                    b.HasKey("PromoId");

                    b.HasIndex("BurgerId");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("ReveloBurger.Models.Promo", b =>
                {
                    b.HasOne("ReveloBurger.Models.Burger", "Burger")
                        .WithMany("Promos")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("ReveloBurger.Models.Burger", b =>
                {
                    b.Navigation("Promos");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_jhalver6.Models;

namespace Mission06_jhalver6.Migrations
{
    [DbContext(typeof(MovieCollectionContext))]
    partial class MovieCollectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_jhalver6.Models.AddMovie", b =>
                {
                    b.Property<int>("Movieid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Movieid");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Movieid = 1,
                            Category = "Adventure",
                            Director = "Kevin Reynolds",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Count of Monte Cristo",
                            Year = 2002
                        },
                        new
                        {
                            Movieid = 2,
                            Category = "Romantic Comedy",
                            Director = "Andy Tennant",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Hitch",
                            Year = 2005
                        },
                        new
                        {
                            Movieid = 3,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_jhalver6.Models;

namespace Mission06_jhalver6.Migrations
{
    [DbContext(typeof(MovieCollectionContext))]
    [Migration("20230220222826_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_jhalver6.Models.AddMovie", b =>
                {
                    b.Property<int>("Movieid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Movieid");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Movieid = 1,
                            CategoryId = 1,
                            Director = "Kevin Reynolds",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Count of Monte Cristo",
                            Year = 2002
                        },
                        new
                        {
                            Movieid = 2,
                            CategoryId = 2,
                            Director = "Andy Tennant",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Hitch",
                            Year = 2005
                        },
                        new
                        {
                            Movieid = 3,
                            CategoryId = 3,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        });
                });

            modelBuilder.Entity("Mission06_jhalver6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Romantic Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy"
                        });
                });

            modelBuilder.Entity("Mission06_jhalver6.Models.AddMovie", b =>
                {
                    b.HasOne("Mission06_jhalver6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

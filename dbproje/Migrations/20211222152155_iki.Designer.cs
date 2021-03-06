// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dbproje;

#nullable disable

namespace dbproje.Migrations
{
    [DbContext(typeof(dbprojeContext))]
    [Migration("20211222152155_iki")]
    partial class iki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dbproje.Araba", b =>
                {
                    b.Property<int>("ArabaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArabaID"), 1L, 1);

                    b.Property<string>("KasaTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkaAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelYılı")
                        .HasColumnType("int");

                    b.Property<string>("VitesTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArabaID");

                    b.ToTable("Arabalar");
                });
#pragma warning restore 612, 618
        }
    }
}

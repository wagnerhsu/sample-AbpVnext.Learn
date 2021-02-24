﻿// <auto-generated />
using System;
using AbpVnext.Learn.EntityFrameworkCore.DbMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace AbpVnext.Learn.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(DbM_LearnDbContext))]
    partial class DbM_LearnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AbpVnext.Learn.Entitys.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime");

                    b.Property<string>("pass_word")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("user_phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("user_status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.UserAuthorizeList", b =>
                {
                    b.Property<string>("userid")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("sourceid")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("sourcetype")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("userid", "sourceid", "sourcetype");

                    b.ToTable("UserAuthorizeLists");
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.UserAuthorizeList", b =>
                {
                    b.HasOne("AbpVnext.Learn.Entitys.User", null)
                        .WithMany("UserAuthorizeLists")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.User", b =>
                {
                    b.Navigation("UserAuthorizeLists");
                });
#pragma warning restore 612, 618
        }
    }
}

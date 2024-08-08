﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240808041937_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.AppModel.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fk_Product")
                        .HasColumnType("int");

                    b.Property<int>("Fk_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Fk_Product");

                    b.HasIndex("Fk_user");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entity.AppModel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Offer")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entity.AppModel.ProductRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fk_Product")
                        .HasColumnType("int");

                    b.Property<int>("Fk_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Fk_Product");

                    b.HasIndex("Fk_user");

                    b.ToTable("ProductRatings");
                });

            modelBuilder.Entity("Entity.AppModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.AuthModel.AccessLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8003),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8016),
                            Name = "FullAccess"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8019),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8020),
                            Name = "ControlAccess"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8021),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8022),
                            Name = "ViewAccess"
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8216),
                            Email = "Admin@App.com",
                            FullName = "Admin",
                            IsActive = true,
                            JobTitle = "Admin",
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8217),
                            Password = "eddc1212gk"
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUserPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fk_accessLevel")
                        .HasColumnType("int");

                    b.Property<int>("Fk_systemUser")
                        .HasColumnType("int");

                    b.Property<int>("Fk_systemView")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Fk_accessLevel");

                    b.HasIndex("Fk_systemUser");

                    b.HasIndex("Fk_systemView");

                    b.ToTable("SystemUserPermissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8377),
                            Fk_accessLevel = 1,
                            Fk_systemUser = 1,
                            Fk_systemView = 1,
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8379)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382),
                            Fk_accessLevel = 1,
                            Fk_systemUser = 1,
                            Fk_systemView = 2,
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384),
                            Fk_accessLevel = 1,
                            Fk_systemUser = 1,
                            Fk_systemView = 3,
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384)
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemViews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8183),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8184),
                            Name = "Home"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8186),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8187),
                            Name = "SystemView"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8188),
                            LastModifiedAt = new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8189),
                            Name = "SystemUser"
                        });
                });

            modelBuilder.Entity("Entity.AppModel.Order", b =>
                {
                    b.HasOne("Entity.AppModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Fk_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AppModel.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("Fk_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.AppModel.ProductRating", b =>
                {
                    b.HasOne("Entity.AppModel.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("Fk_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AppModel.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("Fk_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUserPermission", b =>
                {
                    b.HasOne("Entity.AuthModel.AccessLevel", "AccessLevel")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("Fk_accessLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AuthModel.SystemUser", "SystemUser")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("Fk_systemUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AuthModel.SystemView", "SystemView")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("Fk_systemView")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessLevel");

                    b.Navigation("SystemUser");

                    b.Navigation("SystemView");
                });

            modelBuilder.Entity("Entity.AppModel.Product", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Entity.AppModel.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Entity.AuthModel.AccessLevel", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUser", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemView", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}

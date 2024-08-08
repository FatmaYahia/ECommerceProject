using Common;
using Entity.AppModel;
using Entity.AuthModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.DataEnum;

namespace DAL
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<SystemView> SystemViews { get; set; }
        public DbSet<SystemUserPermission> SystemUserPermissions { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>()
                .HasData(
                new AccessLevel { Id = (int)AccessLevelEnum.FullAccess, Name = "FullAccess", },
                new AccessLevel { Id = (int)AccessLevelEnum.ControlAccess, Name = "ControlAccess", },
                new AccessLevel { Id = (int)AccessLevelEnum.ViewAccess, Name = "ViewAccess", }

                );
            modelBuilder.Entity<SystemView>()
                .HasData(
                new SystemView { Id = (int)SystemViewEnum.Home, Name = "Home", },
                new SystemView { Id = (int)SystemViewEnum.SystemView, Name = "SystemView", },
                new SystemView { Id = (int)SystemViewEnum.SystemUser, Name = "SystemUser", }

                );
            modelBuilder.Entity<SystemUser>()
              .HasData(
              new SystemUser { Id = 1, FullName = "Admin", Email = "Admin@App.com", Password = RandomGenerator.RandomKey(), JobTitle = "Admin", IsActive = true }
              );
            modelBuilder.Entity<SystemUserPermission>()
                .HasData(
                new SystemUserPermission { Id = 1, Fk_systemUser = 1, Fk_systemView = (int)SystemViewEnum.Home, Fk_accessLevel = (int)AccessLevelEnum.FullAccess },
                new SystemUserPermission { Id = 2, Fk_systemUser = 1, Fk_systemView = (int)SystemViewEnum.SystemView, Fk_accessLevel = (int)AccessLevelEnum.FullAccess },
                new SystemUserPermission { Id = 3, Fk_systemUser = 1, Fk_systemView = (int)SystemViewEnum.SystemUser, Fk_accessLevel = (int)AccessLevelEnum.FullAccess }


                );
        }


    }
}


﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectroShop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ElectroShopEntities : DbContext
    {
        public ElectroShopEntities()
            : base("name=ElectroShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<ProductPrices> ProductPrices { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<Types> Types { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectManagerConnection : DbContext
    {
        public ProjectManagerConnection()
            : base("name=ProjectManagerConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_project> tbl_project { get; set; }
        public virtual DbSet<tbl_task> tbl_task { get; set; }
        public virtual DbSet<tbl_users> tbl_users { get; set; }
        public virtual DbSet<tbl_parent_task> tbl_parent_task { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademyApp.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AcademyWsrEntities1 : DbContext
    {
        public AcademyWsrEntities1()
            : base("name=AcademyWsrEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<FormTime> FormTime { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<NameGroup> NameGroup { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Special> Special { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<YearAdd> YearAdd { get; set; }
    }
}
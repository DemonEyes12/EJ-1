﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EJ
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDEntities : DbContext
    {
        private static BDEntities _context;
        public BDEntities()
            : base("name=BDEntities")
        {
        }

        public static BDEntities GetContext()
        {
            if (_context == null)
                _context = new BDEntities();

            return _context;
        }

        public static BDEntities db = new BDEntities();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Lessons_by_subject> Lessons_by_subject { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

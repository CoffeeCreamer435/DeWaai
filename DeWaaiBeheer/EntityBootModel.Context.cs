﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeWaaiBeheer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class u480787545_dewaaEntities : DbContext
    {
        public u480787545_dewaaEntities()
            : base("name=u480787545_dewaaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BookedCursus> BookedCursus { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Fleet> Fleet { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<InstructorsAvailability> InstructorsAvailability { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Registrations> Registrations { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StellerAcunMedyaAkademiPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StellerAcunMedyaDbEntities : DbContext
    {
        public StellerAcunMedyaDbEntities()
            : base("name=StellerAcunMedyaDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblTestimonial> TblTestimonial { get; set; }
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblContect> TblContect { get; set; }
        public virtual DbSet<TblFeature> TblFeature { get; set; }
        public virtual DbSet<TblMessage> TblMessage { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblSkill> TblSkill { get; set; }
        public virtual DbSet<TblSocialMedia> TblSocialMedia { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataLayer.Models
{
    public partial class SurveyDBContext : DbContext
    {
        public SurveyDBContext()
        {
        }

        public SurveyDBContext(DbContextOptions<SurveyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public object Output { get; internal set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sport>(entity =>
            {
                entity.Property(e => e.SportId).HasColumnName("SportID");

                entity.Property(e => e.SportName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.SportName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public DbSet<DataLayer.Models.Output> Output_1 { get; set; }
    }
}

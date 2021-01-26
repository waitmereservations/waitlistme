using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Waitlistme.Domain.Models;

#nullable disable

namespace Waitlistme.Persistence.Contexts
{
    public partial class WaitlistmeContext : DbContext
    {
        public WaitlistmeContext()
        {
        }

        public WaitlistmeContext(DbContextOptions<WaitlistmeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiningTable> DiningTables { get; set; }
        public virtual DbSet<DiningTableStatus> DiningTableStatuses { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PartyDiningTable> PartyDiningTables { get; set; }
        public virtual DbSet<PartyStatus> PartyStatuses { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DiningTable>(entity =>
            {
                entity.ToTable("DiningTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.TableStatusId).HasColumnName("tableStatusId");
            });

            modelBuilder.Entity<DiningTableStatus>(entity =>
            {
                entity.ToTable("DiningTableStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.ToTable("Party");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.PartySize).HasColumnName("partySize");

                entity.Property(e => e.PartyStatusId).HasColumnName("partyStatusId");

                entity.Property(e => e.PartyTypeid).HasColumnName("partyTypeid");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.QuoteTime).HasColumnName("quoteTime");

                entity.Property(e => e.ReservationConfirmed).HasColumnName("reservationConfirmed");

                entity.Property(e => e.ReservationTime)
                    .HasColumnType("date")
                    .HasColumnName("reservationTime");
            });

            modelBuilder.Entity<PartyDiningTable>(entity =>
            {
                entity.ToTable("PartyDiningTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.DiningTableId).HasColumnName("diningTableId");

                entity.Property(e => e.PartyId).HasColumnName("partyId");
            });

            modelBuilder.Entity<PartyStatus>(entity =>
            {
                entity.ToTable("PartyStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PartyType>(entity =>
            {
                entity.ToTable("PartyType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

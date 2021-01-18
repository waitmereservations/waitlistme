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

        public virtual DbSet<FloorTable> FloorTables { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PartyStatus> PartyStatuses { get; set; }
        public virtual DbSet<PartyTableLog> PartyTableLogs { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }
        public virtual DbSet<TableStatus> TableStatuses { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Waitlistme;User ID=sa;Password=TutoTutoTut0;");
            }
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FloorTable>(entity =>
            {
                entity.ToTable("FloorTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.PartyId).HasColumnName("partyId");

                entity.Property(e => e.TableStatusId).HasColumnName("tableStatusId");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.FloorTables)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FloorTable_Party");

                entity.HasOne(d => d.TableStatus)
                    .WithMany(p => p.FloorTables)
                    .HasForeignKey(d => d.TableStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FloorTable_TableStatus");
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

                entity.Property(e => e.FloorTableId).HasColumnName("floorTableId");

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

                entity.HasOne(d => d.FloorTable)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.FloorTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Party_FloorTable");

                entity.HasOne(d => d.PartyStatus)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.PartyStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Party_PartyStatus");

                entity.HasOne(d => d.PartyType)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.PartyTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Party_PartyType");
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

            modelBuilder.Entity<PartyTableLog>(entity =>
            {
                entity.ToTable("PartyTableLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionMsg)
                    .HasMaxLength(50)
                    .HasColumnName("actionMsg");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.PartyId).HasColumnName("partyId");

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.Property(e => e.TableStatusId).HasColumnName("tableStatusId");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyTableLogs)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartyTableLog_Party");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.PartyTableLogs)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartyTableLog_FloorTable");

                entity.HasOne(d => d.TableStatus)
                    .WithMany(p => p.PartyTableLogs)
                    .HasForeignKey(d => d.TableStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartyTableLog_TableStatusID");
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

            modelBuilder.Entity<TableStatus>(entity =>
            {
                entity.ToTable("TableStatus");

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

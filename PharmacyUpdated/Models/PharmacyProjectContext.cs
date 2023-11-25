using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class PharmacyProjectContext : DbContext
    {
        public PharmacyProjectContext()
        {
        }

        public PharmacyProjectContext(DbContextOptions<PharmacyProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<FinalDb> FinalDbs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-90ADLL6\\SQLEXPRESS;Initial Catalog=PharmacyProject;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("drugs");

                entity.Property(e => e.DrugId).HasColumnName("drugId");

                entity.Property(e => e.DrugName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("drugName");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiryDate");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                //entity.HasOne(d => d.Supplier)
                //    .WithMany(p => p.Drugs)
                //    .HasForeignKey(d => d.SupplierId)
                //    .HasConstraintName("FK__drugs__supplierI__4E88ABD4");
            });

            modelBuilder.Entity<FinalDb>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__FinalDb__0809335DEDC62391");

                entity.ToTable("FinalDb");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.DrugExp)
                    .HasColumnType("date")
                    .HasColumnName("drugExp");

                entity.Property(e => e.DrugId).HasColumnName("drugId");

                entity.Property(e => e.DrugName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("drugName");

                entity.Property(e => e.IsPicked)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                //entity.HasOne(d => d.Drug)
                //    .WithMany(p => p.FinalDbs)
                //    .HasForeignKey(d => d.DrugId)
                //    .HasConstraintName("FK__FinalDb__drugId__5812160E");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.FinalDbs)
                //    .HasForeignKey(d => d.UserId)
                //    .HasConstraintName("FK__FinalDb__userId__571DF1D5");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.SupplierContact).HasColumnName("supplierContact");

                entity.Property(e => e.SupplierEmail)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("supplierEmail");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("supplierName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("userAddress");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_Core_DbFirst.Models;

public partial class LpuDbContext : DbContext
{
    public LpuDbContext()
    {
    }

    public LpuDbContext(DbContextOptions<LpuDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }

    public virtual DbSet<StudentMark> StudentMarks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.\\Sqlexpress;Initial Catalog=LPU_DB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3214EC07ED972CA7");

            entity.ToTable("Person", "PankajBatch");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Products__042785C5A577B5DE");

            entity.Property(e => e.ProdId)
                .ValueGeneratedNever()
                .HasColumnName("ProdID");
            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.HasKey(e => e.RollNo).HasName("PK__StudentI__7886D5A0C840120B");

            entity.ToTable("StudentInfo");

            entity.Property(e => e.RollNo).ValueGeneratedNever();
            entity.Property(e => e.LocalAddr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PerAddr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SchoolName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Air Force School");
        });

        modelBuilder.Entity<StudentMark>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Perc).HasComputedColumnSql("((([Physics]+[Chem])+[Maths])/(3))", false);
            entity.Property(e => e.SrNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("srNo");
            entity.Property(e => e.TotalMarks).HasComputedColumnSql("(([Physics]+[Chem])+[Maths])", false);

            entity.HasOne(d => d.RollNoNavigation).WithMany()
                .HasForeignKey(d => d.RollNo)
                .HasConstraintName("FK__StudentMa__RollN__68487DD7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

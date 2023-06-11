using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace duckling_days.MODEL;

public partial class DbSet : DbContext
{
    public DbSet()
    {
    }

    public DbSet(DbContextOptions<DbSet> options)
        : base(options)
    {
    }

    public virtual DbSet<TbPhoto> TbPhotos { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserPhoto> TbUserPhotos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ferna\\source\\repos\\duckling_days_backend\\duckling_days.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbPhoto>(entity =>
        {
            entity.HasKey(e => e.IdPhoto).HasName("PK__TB_photo__059CACB8F6AC3A73");

            entity.ToTable("TB_photo");

            entity.Property(e => e.IdPhoto).HasColumnName("ID_photo");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsFixedLength()
                .HasColumnName("description");
            entity.Property(e => e.DtDay)
                .HasColumnType("datetime")
                .HasColumnName("DT_day");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("title");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__tmp_ms_x__D7B4671EBA8033FD");

            entity.ToTable("TB_user");

            entity.Property(e => e.IdUser).HasColumnName("ID_user");
            entity.Property(e => e.DtBirth)
                .HasColumnType("datetime")
                .HasColumnName("DT_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("user");
        });

        modelBuilder.Entity<TbUserPhoto>(entity =>
        {
            entity.HasKey(e => e.IdUserPhoto).HasName("PK__TB_user___96A97139569E60E7");

            entity.ToTable("TB_user_photo");

            entity.Property(e => e.IdUserPhoto).HasColumnName("ID_user_photo");
            entity.Property(e => e.IdPhoto).HasColumnName("ID_photo");
            entity.Property(e => e.IdUser).HasColumnName("ID_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

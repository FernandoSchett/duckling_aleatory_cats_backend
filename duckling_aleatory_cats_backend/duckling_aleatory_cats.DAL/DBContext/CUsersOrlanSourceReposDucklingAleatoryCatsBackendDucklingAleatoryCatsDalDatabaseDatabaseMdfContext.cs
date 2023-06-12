using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace duckling_aleatory_cats.DAL.DBContext;

public partial class CUsersOrlanSourceReposDucklingAleatoryCatsBackendDucklingAleatoryCatsDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersOrlanSourceReposDucklingAleatoryCatsBackendDucklingAleatoryCatsDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersOrlanSourceReposDucklingAleatoryCatsBackendDucklingAleatoryCatsDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersOrlanSourceReposDucklingAleatoryCatsBackendDucklingAleatoryCatsDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbCat> TbCats { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserCat> TbUserCats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Orlan\\source\\repos\\duckling_aleatory_cats_backend\\duckling_aleatory_cats.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCat>(entity =>
        {
            entity.HasKey(e => e.IdCat).HasName("PK__TB_cat__23F978365F09418C");

            entity.ToTable("TB_cat");

            entity.Property(e => e.IdCat).HasColumnName("ID_cat");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UrlBanner)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL_banner");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__TB_user__D7B4671E44757761");

            entity.ToTable("TB_user");

            entity.Property(e => e.IdUser).HasColumnName("ID_user");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TbUserCat>(entity =>
        {
            entity.HasKey(e => e.IdUserCat).HasName("PK__TB_user___5C927C8154CE5DB9");

            entity.ToTable("TB_user_cat");

            entity.Property(e => e.IdUserCat).HasColumnName("ID_user_cat");
            entity.Property(e => e.IdCat).HasColumnName("ID_cat");
            entity.Property(e => e.IdUser).HasColumnName("ID_user");

            entity.HasOne(d => d.IdCatNavigation).WithMany(p => p.TbUserCats)
                .HasForeignKey(d => d.IdCat)
                .HasConstraintName("FK__TB_user_c__ID_ca__3D5E1FD2");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TbUserCats)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__TB_user_c__ID_us__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EGE;

public partial class TreningContext : DbContext
{
    public TreningContext()
    {
    }

    public TreningContext(DbContextOptions<TreningContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Rule> Rules { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=.\\trening.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rule>(entity =>
        {
            entity.HasKey(e => e.IdRules);

            entity.HasIndex(e => e.IdRules, "IX_Rules_id_rules").IsUnique();

            entity.Property(e => e.IdRules)
                .ValueGeneratedNever()
                .HasColumnName("id_rules");
            entity.Property(e => e.Link)
                .HasColumnType("STRING")
                .HasColumnName("link");
            entity.Property(e => e.Ruledescription).HasColumnName("ruledescription");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Users_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Pass).HasColumnName("pass");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

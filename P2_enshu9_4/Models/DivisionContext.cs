using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P2_enshu9_4.Models;

public partial class DivisionContext : DbContext
{
    public DivisionContext()
    {
    }

    public DivisionContext(DbContextOptions<DivisionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Division> Divisions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\miki\\source\\repos\\P2_enshu9_4\\P2_enshu9_4\\Database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.DivisionId).HasName("PK__tmp_ms_x__20EFC6A81C82116C");

            entity.ToTable("Division");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

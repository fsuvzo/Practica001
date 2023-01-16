using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practica01.Models;

public partial class ExampleSystembdContext : DbContext
{
    public ExampleSystembdContext()
    {
    }

    public ExampleSystembdContext(DbContextOptions<ExampleSystembdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acceso> Accesos { get; set; }

    public virtual DbSet<Perfile> Perfiles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(Localdb)\\felipesv;Database=Sistema;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acceso>(entity =>
        {
            entity.HasKey(e => e.AccesoId).HasName("PK__Acceso__66CA11193B933E2D");

            entity.ToTable("Acceso");

            entity.Property(e => e.AccesoId).ValueGeneratedNever();
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Perfile>(entity =>
        {
            entity.HasKey(e => e.PerfilId).HasName("PK__Perfiles__0C005B66914B01CB");

            entity.Property(e => e.PerfilId)
                .ValueGeneratedNever()
                .HasColumnName("PerfilID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC0704284DAD");

            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

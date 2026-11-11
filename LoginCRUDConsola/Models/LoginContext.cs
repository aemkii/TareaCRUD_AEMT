using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginCRUDConsola.Models;

public partial class LoginContext : DbContext
{
    public LoginContext(DbContextOptions<LoginContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__5B65BF97F1AAA616");

            entity.HasIndex(e => e.Nickname, "UQ__Usuarios__CC6CD17EA7B8A6D4").IsUnique();

            entity.Property(e => e.Contrasenia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nickname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConexionDatos.EDM;

public partial class ExamenPdpContext : DbContext
{
    public ExamenPdpContext()
    {
    }

    public ExamenPdpContext(DbContextOptions<ExamenPdpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExaCArea> ExaCAreas { get; set; }

    public virtual DbSet<ExaTEmpleado> ExaTEmpleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=pruebasbd.database.windows.net;database=ExamenPDP;Trusted_Connection=false;user=pruebasBDMML;password=#pru3b4s3xam3n3s");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExaCArea>(entity =>
        {
            entity.HasKey(e => e.IdArea);

            entity.ToTable("EXA_C_Areas");

            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ExaTEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado);

            entity.ToTable("EXA_T_Empleados");

            entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");
            entity.Property(e => e.Amaterno)
                .HasMaxLength(50)
                .HasColumnName("AMaterno");
            entity.Property(e => e.Apaterno)
                .HasMaxLength(50)
                .HasColumnName("APaterno");
            entity.Property(e => e.Estatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using Microsoft.EntityFrameworkCore;
using TareaFinal.Modelos;

namespace TareaFinal.Modelos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TareaFinal.Modelos.GradoAcademico> GradoAcademico { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Ocupacion> Ocupacion { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Nacionalidad> Nacionalidad { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Religion> Religion { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Carrera> Carrera { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Facultad> Facultad { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Departamento> Departamento { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.AFP> AFP { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.ARS> ARS { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Empleado> Empleado { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<TareaFinal.Modelos.Profesor> Profesor { get; set; } = default!;


    }
}

using Microsoft.EntityFrameworkCore;
using SchoolApp.DAL.Models.dbo;

namespace SchoolApp.DAL.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}


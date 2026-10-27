using Microsoft.Extensions.DependencyInjection;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Repositories.dbo;

namespace SchoolApp.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddScoped<IEstudianteRepository, EstudianteRepository>();
            services.AddScoped<IProfesorRepository, ProfesorRepository>();
            services.AddScoped<IAsignaturaRepository, AsignaturaRepository>();

            return services;
        }
    }
}

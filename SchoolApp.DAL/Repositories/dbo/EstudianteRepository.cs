using SchoolApp.DAL.Base;
using SchoolApp.DAL.Context;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Models.dbo;

namespace SchoolApp.DAL.Repositories.dbo
{
    public class EstudianteRepository : BaseRepository<Estudiante>, IEstudianteRepository
    {
        public EstudianteRepository(SchoolContext context) : base(context)
        {
        }
    }
}

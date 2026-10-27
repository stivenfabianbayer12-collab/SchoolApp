using SchoolApp.DAL.Base;
using SchoolApp.DAL.Context;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Models.dbo;

namespace SchoolApp.DAL.Repositories.dbo
{
    public class ProfesorRepository : BaseRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(SchoolContext context) : base(context)
        {
        }
    }
}
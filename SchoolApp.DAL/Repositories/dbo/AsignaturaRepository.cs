using SchoolApp.DAL.Base;
using SchoolApp.DAL.Context;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Models.dbo;

namespace SchoolApp.DAL.Repositories.dbo
{
    public class AsignaturaRepository : BaseRepository<Asignatura>, IAsignaturaRepository
    {
        public AsignaturaRepository(SchoolContext context) : base(context)
        {
        }
    }
}

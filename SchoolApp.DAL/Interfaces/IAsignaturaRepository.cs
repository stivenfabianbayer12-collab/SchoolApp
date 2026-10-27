using SchoolApp.DAL.Models.dbo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolApp.DAL.Interfaces
{
    public interface IAsignaturaRepository
    {
        Task<IEnumerable<Asignatura>> GetAllAsync();
        Task<Asignatura> GetByIdAsync(int id);
        Task AddAsync(Asignatura asignatura);
        Task UpdateAsync(Asignatura asignatura);
        Task DeleteAsync(int id);
    }
}
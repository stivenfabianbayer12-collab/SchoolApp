using SchoolApp.DAL.Models.dbo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolApp.DAL.Interfaces
{
    public interface IEstudianteRepository
    {
        Task<IEnumerable<Estudiante>> GetAllAsync();
        Task<Estudiante> GetByIdAsync(int id);
        Task AddAsync(Estudiante estudiante);
        Task UpdateAsync(Estudiante estudiante);
        Task DeleteAsync(int id);
    }
}
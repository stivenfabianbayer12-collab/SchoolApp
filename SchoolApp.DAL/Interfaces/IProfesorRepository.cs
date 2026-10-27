using SchoolApp.DAL.Models.dbo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolApp.DAL.Interfaces
{
    public interface IProfesorRepository
    {
        Task<IEnumerable<Profesor>> GetAllAsync();
        Task<Profesor> GetByIdAsync(int id);
        Task AddAsync(Profesor profesor);
        Task UpdateAsync(Profesor profesor);
        Task DeleteAsync(int id);
    }
}

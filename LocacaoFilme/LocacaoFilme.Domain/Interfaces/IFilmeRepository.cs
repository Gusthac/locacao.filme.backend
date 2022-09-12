using LocacaoFilme.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Domain.Interfaces
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> GetFilmesAsync();
        Task<Filme> GetByIdAsync(int id);
        Task<Filme> CreateAsync(Filme filme);
        Task<Filme> UpdateAsync(Filme filme);
        Task<Filme> RemoveAsync(Filme filme);
    }
}

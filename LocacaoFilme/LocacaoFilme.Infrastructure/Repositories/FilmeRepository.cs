using LocacaoFilme.Domain.Entities;
using LocacaoFilme.Domain.Interfaces;
using LocacaoFilme.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Infrastructure.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly ApplicationDbContext _filmeContext;
        public FilmeRepository(ApplicationDbContext context)
        {
            _filmeContext = context;
        }

        public async Task<Filme> CreateAsync(Filme filme)
        {
            _filmeContext.Add(filme);
            await _filmeContext.SaveChangesAsync();
            return filme;
        }

        public async Task<Filme> GetByIdAsync(int id)
        {
            return await _filmeContext.Filmes.FindAsync(id);
        }

        public async Task<IEnumerable<Filme>> GetFilmesAsync()
        {
            return await _filmeContext.Filmes.ToListAsync();
        }

        public async Task<Filme> RemoveAsync(Filme filme)
        {
            _filmeContext.Remove(filme);
            await _filmeContext.SaveChangesAsync();
            return filme;
        }

        public async Task<Filme> UpdateAsync(Filme filme)
        {
            _filmeContext.Update(filme);
            await _filmeContext.SaveChangesAsync();
            return filme;
        }
    }
}

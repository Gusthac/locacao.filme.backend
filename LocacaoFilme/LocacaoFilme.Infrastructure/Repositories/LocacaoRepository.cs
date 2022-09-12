using LocacaoFilme.Domain.Entities;
using LocacaoFilme.Domain.Interfaces;
using LocacaoFilme.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Infrastructure.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly ApplicationDbContext _locacaoContext;
        public LocacaoRepository(ApplicationDbContext context)
        {
            _locacaoContext = context;
        }
        public async Task<Locacao> CreateAsync(Locacao locacao)
        {
            _locacaoContext.Add(locacao);
            await _locacaoContext.SaveChangesAsync();
            return locacao;

        }

        public async Task<Locacao> GetByIdAsync(int id)
        {
            return await _locacaoContext.Locacoes.FindAsync(id);
        }

        public async Task<IEnumerable<Locacao>> GetLocacoesAsync()
        {
            return await _locacaoContext.Locacoes.ToListAsync();
        }

        public async Task<Locacao> RemoveAsync(Locacao locacao)
        {
            _locacaoContext.Remove(locacao);
            await _locacaoContext.SaveChangesAsync();
            return locacao;
        }

        public async Task<Locacao> UpdateAsync(Locacao locacao)
        {
            _locacaoContext.Update(locacao);
            await _locacaoContext.SaveChangesAsync();
            return locacao;
        }

        public async Task<Filme> GetFilmeByIdAsync(int idFilme)
        {
            return await _locacaoContext.Filmes.FindAsync(idFilme);
        }
        public async Task<Cliente> GetClienteByIdAsync(int idCliente)
        {
            return await _locacaoContext.Clientes.FindAsync(idCliente);
        }
    }
}

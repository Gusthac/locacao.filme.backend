using LocacaoFilme.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Domain.Interfaces
{
    public interface ILocacaoRepository
    {
        Task<IEnumerable<Locacao>> GetLocacoesAsync();
        Task<Locacao> GetByIdAsync(int id);
        Task<Locacao> CreateAsync(Locacao locacao);
        Task<Locacao> UpdateAsync(Locacao locacao);
        Task<Locacao> RemoveAsync(Locacao locacao);
        Task<Filme> GetFilmeByIdAsync(int idFilme);
        Task<Cliente> GetClienteByIdAsync(int idCliente);
    }
}

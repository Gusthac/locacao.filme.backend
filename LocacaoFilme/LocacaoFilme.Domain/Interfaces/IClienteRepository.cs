using LocacaoFilme.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetByIdAsync(int id);
        Task<Cliente> CreateAsync(Cliente cliente);
        Task<Cliente> UpdateAsync(Cliente cliente);
        Task<Cliente> RemoveAsync(Cliente cliente);
    }
}

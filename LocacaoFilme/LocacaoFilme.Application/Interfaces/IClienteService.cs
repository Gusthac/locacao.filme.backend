using LocacaoFilme.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDTO>> GetClientes();
        Task<ClienteDTO> GetById(int id);
        Task<ClienteDTO> Add(ClienteDTO clienteDto);
        Task Update(ClienteDTO clienteDto);
        Task Remove(int id);
    }
}
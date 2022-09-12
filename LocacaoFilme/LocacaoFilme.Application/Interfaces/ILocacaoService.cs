using LocacaoFilme.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Application.Interfaces
{
    public interface ILocacaoService
    {
        Task<IEnumerable<LocacaoDTO>> GetLocacoes();
        Task<LocacaoDTO> GetById(int id);
        Task<LocacaoDTO> Add(LocacaoDTO locacaoDto);
        Task<LocacaoDTO> Update(LocacaoDTO locacaoDto);
        Task Remove(int id);
    }
}

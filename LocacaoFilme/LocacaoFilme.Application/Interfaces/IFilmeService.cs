using LocacaoFilme.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Application.Interfaces
{
    public interface IFilmeService
    {
        Task<IEnumerable<FilmeDTO>> GetFilmes();
        Task<FilmeDTO> GetById(int id);
        Task<FilmeDTO> Add(FilmeDTO filmeDto);
        Task Update(FilmeDTO filmeDto);
        Task Remove(int id);
    }
}

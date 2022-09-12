using AutoMapper;
using LocacaoFilme.Application.DTOs;
using LocacaoFilme.Application.Interfaces;
using LocacaoFilme.Domain.Entities;
using LocacaoFilme.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.Application.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IMapper _mapper;
        public FilmeService(IFilmeRepository filmeRepository,
            IMapper mapper)
        {
            _filmeRepository = filmeRepository;
            _mapper = mapper;
        }

        public async Task<FilmeDTO> Add(FilmeDTO filmeDto)
        {
            var filmeEntity = _mapper.Map<Filme>(filmeDto);
            var filme = await _filmeRepository.CreateAsync(filmeEntity);
            return _mapper.Map<FilmeDTO>(filme);
        }

        public async Task<FilmeDTO> GetById(int id)
        {
            var filmeEntity = await _filmeRepository.GetByIdAsync(id);
            return _mapper.Map<FilmeDTO>(filmeEntity);
        }

        public async Task<IEnumerable<FilmeDTO>> GetFilmes()
        {
            var filmeEntity = await _filmeRepository.GetFilmesAsync();
            return _mapper.Map<IEnumerable<FilmeDTO>>(filmeEntity);
        }

        public async Task Remove(int id)
        {
            var filmeEntity = _filmeRepository.GetByIdAsync(id).Result;
            await _filmeRepository.RemoveAsync(filmeEntity);
        }

        public async Task Update(FilmeDTO filmeDto)
        {
            var filmeEntity = _mapper.Map<Filme>(filmeDto);
            await _filmeRepository.UpdateAsync(filmeEntity);
        }
    }
}

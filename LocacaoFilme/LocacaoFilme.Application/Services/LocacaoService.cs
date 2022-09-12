using AutoMapper;
using LocacaoFilme.Application.Constantes;
using LocacaoFilme.Application.DTOs;
using LocacaoFilme.Application.Interfaces;
using LocacaoFilme.Domain.Entities;
using LocacaoFilme.Domain.Enums;
using LocacaoFilme.Domain.Interfaces;
using LocacaoFilme.Application.Validation;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace LocacaoFilme.Application.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;
        private readonly IMapper _mapper;
        public LocacaoService(ILocacaoRepository locacaoRepository,
            IMapper mapper)
        {
            _locacaoRepository = locacaoRepository;
            _mapper = mapper;
        }

        public async Task<LocacaoDTO> Add(LocacaoDTO locacaoDto)
        {
            try
            {
                var locacaoEntity = _mapper.Map<Locacao>(locacaoDto);

                var filmeEntity = await _locacaoRepository.GetFilmeByIdAsync(locacaoEntity.Id_Filme);
                ApplicationExceptionValidation.When(filmeEntity is null, "Código de filme não cadastrado.");

                var clienteEntity = await _locacaoRepository.GetClienteByIdAsync(locacaoEntity.Id_Cliente);
                ApplicationExceptionValidation.When(clienteEntity is null, "Código de cliente não cadastrado.");

                locacaoEntity.DataDevolucao = filmeEntity.Lancamento == (byte)StatusLancamentoFilme.Lancamento ?
                      locacaoEntity.DataLocacao.AddDays(PrazoDevolucao.PrazoDevolucaoFilmeLancamento) :
                      locacaoEntity.DataLocacao.AddDays(PrazoDevolucao.PrazoDevolucaoFilmeComum);

                var locacao = await _locacaoRepository.CreateAsync(locacaoEntity);
                return _mapper.Map<LocacaoDTO>(locacao);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }

        public async Task<LocacaoDTO> GetById(int id)
        {
            var locacaoEntity = await _locacaoRepository.GetByIdAsync(id);
            return _mapper.Map<LocacaoDTO>(locacaoEntity);
        }

        public async Task<IEnumerable<LocacaoDTO>> GetLocacoes()
        {
            var locacaoEntity = await _locacaoRepository.GetLocacoesAsync();
            return _mapper.Map<IEnumerable<LocacaoDTO>>(locacaoEntity);
        }

        public async Task Remove(int id)
        {
            var locacaoEntity = _locacaoRepository.GetByIdAsync(id).Result;
            await _locacaoRepository.RemoveAsync(locacaoEntity);
        }

        public async Task<LocacaoDTO> Update(LocacaoDTO locacaoDto)
        {
            try
            {
                var locacaoEntity = _mapper.Map<Locacao>(locacaoDto);

                var filmeEntity = await _locacaoRepository.GetFilmeByIdAsync(locacaoEntity.Id_Filme);
                ApplicationExceptionValidation.When(filmeEntity is null, "Código de filme não cadastrado.");

                var clienteEntity = await _locacaoRepository.GetClienteByIdAsync(locacaoEntity.Id_Cliente);
                ApplicationExceptionValidation.When(clienteEntity is null, "Código de cliente não cadastrado.");

                var locacao = await _locacaoRepository.UpdateAsync(locacaoEntity);
                return _mapper.Map<LocacaoDTO>(locacao);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }



        }
    }
}

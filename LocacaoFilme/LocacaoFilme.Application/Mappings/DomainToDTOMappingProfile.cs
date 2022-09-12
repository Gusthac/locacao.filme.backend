using AutoMapper;
using LocacaoFilme.Application.DTOs;
using LocacaoFilme.Domain.Entities;

namespace LocacaoFilme.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Filme, FilmeDTO>().ReverseMap();
            CreateMap<Locacao, LocacaoDTO>().ReverseMap();
        }
    }
}
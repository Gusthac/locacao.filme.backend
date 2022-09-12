using LocacaoFilme.Application.DTOs;
using LocacaoFilme.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocacoesController : ControllerBase
    {
        private readonly ILocacaoService _locacaoService;
        public LocacoesController(ILocacaoService locacaoService)
        {
            _locacaoService = locacaoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocacaoDTO>>> Get()
        {
            var locacoes = await _locacaoService.GetLocacoes();
            return Ok(locacoes);
        }

        [HttpGet("{id}", Name = "GetLocacao")]
        public async Task<ActionResult<LocacaoDTO>> Get(int id)
        {
            var locacao = await _locacaoService.GetById(id);

            if (locacao == null)
            {
                return NotFound();
            }
            return Ok(locacao);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LocacaoDTO locacaoDto)
        {
            var locacao = await _locacaoService.Add(locacaoDto);

            return new CreatedAtRouteResult("GetLocacao",
                new { id = locacao.Id }, locacao);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] LocacaoDTO locacaoDto)
        {
            if (id != locacaoDto.Id)
            {
                return BadRequest();
            }
            await _locacaoService.Update(locacaoDto);
            return Ok(locacaoDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LocacaoDTO>> Delete(int id)
        {
            var locacaoDto = await _locacaoService.GetById(id);
            if (locacaoDto == null)
            {
                return NotFound();
            }
            await _locacaoService.Remove(id);
            return Ok(locacaoDto);
        }
    }
}

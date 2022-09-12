using LocacaoFilme.Application.DTOs;
using LocacaoFilme.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocacaoFilme.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeService _filmeService;
        public FilmesController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmeDTO>>> Get()
        {
            var filmes = await _filmeService.GetFilmes();
            return Ok(filmes);
        }

        [HttpGet("{id}", Name = "GetFilme")]
        public async Task<ActionResult<FilmeDTO>> Get(int id)
        {
            var filme = await _filmeService.GetById(id);

            if (filme == null)
            {
                return NotFound();
            }
            return Ok(filme);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FilmeDTO filmeDto)
        {
            var filme = await _filmeService.Add(filmeDto);

            return new CreatedAtRouteResult("GetFilme",
                new { id = filme.Id }, filme);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] FilmeDTO filmeDto)
        {
            if (id != filmeDto.Id)
            {
                return BadRequest();
            }
            await _filmeService.Update(filmeDto);
            return Ok(filmeDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FilmeDTO>> Delete(int id)
        {
            var filmeDto = await _filmeService.GetById(id);
            if (filmeDto == null)
            {
                return NotFound();
            }
            await _filmeService.Remove(id);
            return Ok(filmeDto);
        }
    }
}

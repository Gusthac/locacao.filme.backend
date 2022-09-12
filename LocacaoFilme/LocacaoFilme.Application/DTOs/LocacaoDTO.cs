using System;
using System.ComponentModel.DataAnnotations;

namespace LocacaoFilme.Application.DTOs
{
    public class LocacaoDTO
    {
        public LocacaoDTO()
        {
            this.DataLocacao = DateTime.Now;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o id do cliente")]
        public int? Id_Cliente { get; set; }

        [Required(ErrorMessage = "Informe o id do filme")]
        public int? Id_Filme { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace LocacaoFilme.Application.DTOs
{
    public class FilmeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do filme")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe a classificação indicativa")]
        [Range(10, 18)]
        public int ClassificacaoIndicativa { get; set; }

        [Required(ErrorMessage = "Informe o tipo de lançamento")]
        [Range(0, 1)]
        public Byte Lancamento { get; set; }
    }
}

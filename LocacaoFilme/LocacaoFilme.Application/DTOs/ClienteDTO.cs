using System;
using System.ComponentModel.DataAnnotations;

namespace LocacaoFilme.Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        [MinLength(1)]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente")]
        [MinLength(1)]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do cliente")]
        public DateTime DataNascimento { get; set; }
    }
}
using System;

namespace LocacaoFilme.Domain.Entities
{
    public class Cliente : BaseDomain
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}

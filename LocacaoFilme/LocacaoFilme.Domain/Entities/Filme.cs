using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoFilme.Domain.Entities
{
    public class Filme : BaseDomain
    {
        public string Titulo { get; private set; }
        public int ClassificacaoIndicativa { get; set; }
        public Byte Lancamento { get; private set; }
    }
}

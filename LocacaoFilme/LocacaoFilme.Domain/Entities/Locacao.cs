using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoFilme.Domain.Entities
{
    public class Locacao : BaseDomain
    {
        public int Id_Cliente { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public int Id_Filme { get; private set; }
        public virtual Filme Filme { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataDevolucao { get; set; }
    }
}

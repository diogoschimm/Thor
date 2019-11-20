using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities.Base;
using Thor.Domain.Shared.ValuesObjects;

namespace Thor.Domain.Shared.Entities
{
    public class Cidade : EntidadeBase
    {
        public int IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public UF UF { get; set; }
        public string CodigoIBGE { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities;
using Thor.Domain.Shared.Entities.Base;

namespace Thor.Domain.NF.Entities
{
    public class ServicoMunicipio : EntidadeBase
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public string CodigoServico { get; set; }
    }
}

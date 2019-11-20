using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities.Base;

namespace Thor.Domain.Shared.Entities
{
    public class CNAE : EntidadeBase
    {
        public int IdCnae { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
    }
}

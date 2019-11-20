using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities;

namespace Thor.Domain.Shared.ValuesObjects
{
    public class InfoCadastro
    {
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
    }
}

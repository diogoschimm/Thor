using System;
using System.Collections.Generic;
using System.Text;

namespace Thor.Domain.Shared.ValuesObjects
{
    public class Imposto
    {
        public decimal BaseCalculo { get; set; }
        public decimal Percentual { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Retido { get; set; }
    }
}

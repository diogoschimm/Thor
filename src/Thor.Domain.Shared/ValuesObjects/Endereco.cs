using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities;

namespace Thor.Domain.Shared.ValuesObjects
{
    public class Endereco
    {
        public CEP CEP { get; set; }
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }
        public string Complemento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Thor.Domain.NF.Entities
{
    public class NFSe
    {
        public int IdNFSe { get; set; }

        public RPS RPS { get; set; }  
        public string Numero { get; set; }
        public string CodigoVerificacao { get; set; }
        public DateTime? DataEmissao { get; set; }
    }
}

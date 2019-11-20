using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.NF.ValuesObjects;
using Thor.Domain.Shared.Entities;
using Thor.Domain.Shared.Entities.Base;
using Thor.Domain.Shared.ValuesObjects;

namespace Thor.Domain.NF.Entities
{
    public class RPS: EntidadeBase
    {
        public Tomador Tomador { get; set; }
        public Prestador Prestador { get; set; }

        public StatusRPS StatusRPS { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataCompetencia { get; set; }

        public string Numero { get; set; }
        public string Serie { get; set; }

        public decimal ValorServico { get; set; }
        public Imposto ISS { get; set; }
        public Imposto PIS { get; set; }
        public Imposto COFINS { get; set; }
        public Imposto INSS { get; set; }
        public Imposto IR { get; set; }
        public Imposto CSLL { get; set; }

        public decimal ValorOutrasRetencoes { get; set; }
        public decimal ValorDescontoCondicionado { get; set; }
        public decimal ValorDescontoIncondicionado { get; set; }
        public decimal ValorLiquido { get; set; }

        public bool SimplesNacional { get; set; }
        public bool IncentivoFiscal { get; set; }

        public ServicoMunicipio ServicoMunicipio { get; set; }
        public string DescricaoServicoPrestado { get; set; }

        public DateTime? DataEnvioPrefeitura { get; set; }
        public RetornoPrefeituraRPS RetornoPrefeituraRPS { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities;

namespace Thor.Domain.NF.Entities
{
    public class Prestador : Pessoa
    {
        public bool Validar()
        {
            this.ValidarNome(nomeCampo: "Nome do Prestador", tamanhoCampo: 100);
            this.ValidarDocumento(nomeCampo: "Documento do Prestador");
            this.ValidarEndereco(nomeCampo: "Endereço do Prestador");

            return this.Valid;
        }
    }
}

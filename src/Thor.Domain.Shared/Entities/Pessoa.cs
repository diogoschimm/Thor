using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.Entities.Base;
using Thor.Domain.Shared.ValuesObjects;

namespace Thor.Domain.Shared.Entities
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
        public CNAE CNAE { get; set; }

        protected bool ValidarNome(string nomeCampo, int tamanhoCampo)
        {
            if (string.IsNullOrEmpty(this.Nome))
                this.AddNotification("Nome", $"{nomeCampo} é obrigatório");

            if (this.Nome != null && this.Nome.Length > 100)
                this.AddNotification("Nome", $"{nomeCampo} não pode ser maior que {tamanhoCampo} caracteres");

            return this.Valid;
        }
        protected bool ValidarDocumento(string nomeCampo)
        {
            if (this.Documento == null)
                this.AddNotification("Documento", $"{nomeCampo} é obrigatório");

            if (this.Documento != null)
            {
                if (!this.Documento.Validar())
                    this.AddNotifications(this.Documento.Notifications);
            }

            return this.Valid;
        }
        protected bool ValidarEndereco(string nomeCampo)
        {
            if (this.Endereco == null)
                this.AddNotification("Endereco", $"{nomeCampo} é obrigatório");

            return this.Valid;
        }
    }
}

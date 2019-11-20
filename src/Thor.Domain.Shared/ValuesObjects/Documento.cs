using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Thor.Domain.Shared.ValuesObjects
{
    public class Documento : Notifiable
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(this.TipoDocumento))
                this.AddNotification("TipoDocumento", "Tipo de Documento é obrigatório");
             
            return this.Valid;
        }
    }
}

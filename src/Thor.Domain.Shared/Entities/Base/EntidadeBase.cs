using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using Thor.Domain.Shared.ValuesObjects;

namespace Thor.Domain.Shared.Entities.Base
{
    public class EntidadeBase : Notifiable
    {
        public InfoCadastro InfoInsercao { get; set; }
        public InfoCadastro InfoAtualizacao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
   public class User : BaseEntity
    {
        public string Nome { get; set; }

        public int SenhaLogin { get; set; }

    }
}

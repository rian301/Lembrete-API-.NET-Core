using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Lembrete : BaseEntity
    {
        public string Texto { get; set; }
        public bool Arquivado { get; set; }
        public string FezOs { get; set; }
        public string Prioridade { get; set; }
        public int Modificado { get; set; }
    }
}

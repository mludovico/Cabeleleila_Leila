using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Horario
    {
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioTermino { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional Profissional { get; set; }
    }
}

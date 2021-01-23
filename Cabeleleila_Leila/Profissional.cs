using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Profissional : Pessoa

    {
        public int CodigoProf { get; set; }
        public List<Horario> Horarios { get; set; }

    }
}

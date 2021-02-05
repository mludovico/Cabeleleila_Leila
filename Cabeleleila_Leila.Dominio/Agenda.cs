using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    class Agenda
    {
        List<Horario> Horarios;

        public Agenda()
        {
            Horarios = new List<Horario>();
        }

        public Horario Agendar(Cliente cliente, Profissional profissional, Horario horario)
        {
            if (Horarios.Contains(horario))
                return null;
            else
            {
                Horarios.Add(horario);
                return horario;
            }
        }

        public void Desmarcar(Horario horario)
        {
            if (Horarios.Contains(horario))
                Horarios.Remove(horario);
        }
    }
}

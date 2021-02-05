using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Salao
    {
        public Cliente cliente;
        public Profissional profissional;


        public Salao()
        {
            cliente = new Cliente();
            profissional = new Profissional();
        }

        public void listarTodos()
        {
            cliente.Listar();
            profissional.Listar();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class CadastroCliente : Cadastro
    {
        public void Listar()
        {
            Console.WriteLine("\nClientes\n");
            foreach (Pessoa pessoa in Pessoas)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Telefone);
                Console.WriteLine(pessoa.Email);


            }
        }
    }
}

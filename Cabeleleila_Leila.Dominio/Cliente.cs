using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Cliente
    {
        List<Pessoa> Clientes;

        public Cliente()
        {
            Clientes = new List<Pessoa>();
        }

        public void cadastrar(Pessoa pessoa)
        {
            Clientes.Add(pessoa);
        }
        public void Excluir(string nome)
        {
            int index = -1;
            foreach (Pessoa pessoa in Clientes)
            {
                if (pessoa.Nome == nome)
                    index = Clientes.IndexOf(pessoa);
            }
            if (index >= 0)
                Clientes.RemoveAt(index);
            else
                Console.WriteLine("Nome não encontrado.");
        }
        public void Listar()
        {
            Console.WriteLine("\nClientes\n");
            foreach (Pessoa pessoa in Clientes)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Telefone);
                Console.WriteLine(pessoa.Email);


            }
        }
    }
}

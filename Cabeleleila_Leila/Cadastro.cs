using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Cadastro
    {
        public List<Pessoa> Pessoas { get; set; }

        public Cadastro()
        {
            Pessoas = new List<Pessoa>();
        }
        public void Incluir(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);

        }

        public void Excluir(string nome)
        {
            int index = -1;
            foreach (Pessoa pessoa in Pessoas)
            {
                if(pessoa.Nome == nome)
                {
                    index = Pessoas.IndexOf(pessoa);                    
                }
            }
            if(index >= 0)
                Pessoas.RemoveAt(index);
        }

        public void Listar()
        {
            foreach(Pessoa pessoa in Pessoas)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Telefone);
                Console.WriteLine(pessoa.Email);


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cabeleleila_Leila
{
    public class Profissional

    {
        public List<Pessoa> Profissionais { get; set; }

        public Profissional()
        {
            Profissionais = new List<Pessoa>();
        }
        public void Cadastrar(Pessoa pessoa)
        {
            Profissionais.Add(pessoa);
        }
        public void Excluir(string nome)
        {
            int index = -1;
            foreach (Pessoa pessoa in Profissionais)
            {
                if (pessoa.Nome == nome)
                    index = Profissionais.IndexOf(pessoa);
            }
            if (index >= 0)
                Profissionais.RemoveAt(index);
            else
                Console.WriteLine("Nome não encontrado.");
        }
        public void Listar()
        {
            Console.WriteLine("\nProfissionais\n");
            foreach (Pessoa pessoa in Profissionais)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Telefone);
                Console.WriteLine(pessoa.Email);


            }
        }

    }
}

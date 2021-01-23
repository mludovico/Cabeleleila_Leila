using System;

namespace Cabeleleila_Leila
{
    class Program
    {
        static Cadastro cadastro; 
        static void Main(string[] args)
        {
            cadastro = new Cadastro();
            bool continuar = true;
            while(continuar)
            {
                Console.WriteLine("Deseja incluir ou excluir um cadastro? I - Incluir E - Excluir");
                switch(Console.ReadLine().ToUpper())
                {
                    case "I":
                        Cadastrar();
                        break;
                    case "E":
                        Excluir();
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
                cadastro.Listar();
                Console.WriteLine("Deseja sair? S/N");
                continuar = Console.ReadLine().ToUpper() != "S";


            }
            
        }
        static void Cadastrar()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite o nome");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone");
            pessoa.Telefone = Console.ReadLine();
            Console.WriteLine("Digite o e-mail");
            pessoa.Email = Console.ReadLine();
            cadastro.Incluir(pessoa);           
        }

        static void Excluir()
        {
            Console.WriteLine("Digite o nome que deseja excluir");
            cadastro.Excluir(Console.ReadLine());

        }
    }
}

using System;

namespace Cabeleleila_Leila
{
    class Program
    {
        static public Salao salao;
        static void Main(string[] args)
        {
            salao = new Salao();
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
                salao.listarTodos();
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
            Console.WriteLine("Deseja cadastrar um cliente ou profissional? C - Cliente P - Profissional");
            switch (Console.ReadLine().ToUpper())
            {
                case "C":
                    salao.cliente.cadastrar(pessoa);
                    break;
                case "P":
                    salao.profissional.Cadastrar(pessoa);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
                    
        }

        static void Excluir()
        {
            Console.WriteLine("Deseja excluir um cadastro de cliente ou profissional? C - Cliente P - Profissional");
            switch (Console.ReadLine().ToUpper())
            {
                case "C":
                    Console.WriteLine("Digite o nome que deseja excluir");
                    salao.cliente.Excluir(Console.ReadLine());
                    break;
                case "P":
                    Console.WriteLine("Digite o nome que deseja excluir");
                    salao.profissional.Excluir(Console.ReadLine());                   
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
            
        }
    }
}

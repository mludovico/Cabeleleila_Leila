using System;

namespace Cabeleleila_Leila
{
    class Program
    {
        static CadastroCliente cadastroCliente; 
        static CadastroProf cadastroProf; 
        static void Main(string[] args)
        {
            cadastroCliente = new CadastroCliente();
            cadastroProf = new CadastroProf();
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
                cadastroCliente.Listar();
                cadastroProf.Listar();
                Console.WriteLine("Deseja sair? S/N");
                continuar = Console.ReadLine().ToUpper() != "S";


            }
            
        }
        static void Cadastrar()
        {
            Console.WriteLine("Deseja cadastrar um cliente ou profissional? C - Cliente P - Profissional");
            switch (Console.ReadLine().ToUpper())
            {
                case "C":
                    Cliente cliente = new Cliente();
                    Console.WriteLine("Digite o nome");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o telefone");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o e-mail");
                    cliente.Email = Console.ReadLine();
                    cadastroCliente.Incluir(cliente);
                    break;
                case "P":
                    Profissional profissional = new Profissional();
                    Console.WriteLine("Digite o nome");
                    profissional.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o telefone");
                    profissional.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o e-mail");
                    profissional.Email = Console.ReadLine();
                    cadastroProf.Incluir(profissional);
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
                    cadastroCliente.Excluir(Console.ReadLine());
                    break;
                case "P":
                    Console.WriteLine("Digite o nome que deseja excluir");
                    cadastroProf.Excluir(Console.ReadLine());                   
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
            
        }
    }
}

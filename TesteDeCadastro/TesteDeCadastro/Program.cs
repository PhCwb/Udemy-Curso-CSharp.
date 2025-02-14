using System;
using TesteDeCadastro.Cadastro.CdMotorista;
using TesteDeCadastro.ArmazenamentoDeCadastro;


namespace TesteDeCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorista motorista = new Motorista();
            Console.WriteLine("CADASTRO DE MOTORISTA:\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("------------------------------");

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("------------------------------");

            Console.Write("CNH: ");
            string cnh = Console.ReadLine();
            Console.WriteLine("------------------------------");

            Console.Write("Validade da CNH (DD/MM/YYYY): ");
            DateTime dataDoCadastro = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------\n");


            CadastroDeMotorista cadastroDeMotorista = new CadastroDeMotorista(nome, cpf, cnh, dataDoCadastro);
            motorista.AdicionarMotorista(cadastroDeMotorista);

            Console.WriteLine("Motorista cadastrado com sucesso!\n");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Lista de motorista cadastrado:");
            motorista.ListarMotoristas();

        }
    }
}
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TesteDeCadastro.Cadastro.CdMotorista;

namespace TesteDeCadastro.ArmazenamentoDeCadastro
{
    internal class Motorista
    {
        public List<CadastroDeMotorista> cadastroDeMotoristas;

        public Motorista()
        {
            cadastroDeMotoristas = new List<CadastroDeMotorista>();
        }

        public void AdicionarMotorista(CadastroDeMotorista cadastroDeMotorista)
        {
            cadastroDeMotoristas.Add(cadastroDeMotorista);
        }

        public void ListarMotoristas()
        {
            if (cadastroDeMotoristas.Count == 0)
            {
                Console.WriteLine("Nenhum motorista cadastrado.");
                return;
            }

            Console.WriteLine("Motoristas cadastrados: ");
            foreach (var cadastroDeMotorista in cadastroDeMotoristas)
            {
                Console.WriteLine(cadastroDeMotorista);
            }


        }

        //add, remover...




       


    }
}

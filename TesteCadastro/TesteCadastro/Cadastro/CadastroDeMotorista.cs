using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCadastro.Usuarios;

namespace TesteCadastro.Cadastro
{
    internal class CadastroDeMotorista
    {
        public List<Motorista> motoristas = new List<Motorista>();

        public void AddCadastroDeMotorista(Motorista motorista)//Add
        {
            motoristas.Add(motorista);
        }

        public void RemoverCadastroDeMotorista(Motorista motorista)//Remover
        {
            motoristas.Remove(motorista);
        }


        public void ListaDeMotorista()
        {
            if (motoristas.Count == 0)
            {
                Console.WriteLine("\u001b[31m NENHUM MOTORISTA CADASTRADO!\u001b[0m");
                return;
            }

            Console.WriteLine("MOTORISTAS CADASTRADOS");
            foreach (var motorista in motoristas)
            {
                Console.WriteLine(motorista.ToString());
            }


        }

    }
}

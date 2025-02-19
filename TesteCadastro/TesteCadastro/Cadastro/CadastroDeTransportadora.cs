using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCadastro.Exceptions;
using TesteCadastro.Usuarios;

namespace TesteCadastro.Cadastro
{
    internal class CadastroDeTransportadora
    {
        public List<Transportadora> transportadoras = new List<Transportadora>();


        public void AddCadastroDeTransportadora(Transportadora transportadora)
        {
            transportadoras.Add(transportadora);
        }


        public void ListaDeTransportadora()
        {
            if (transportadoras.Count == 0)
            {
                throw new DomainsException("\u001b[31mNENHUMA TRANSPORTADORA CADASTRADA!\u001b[0m");
            }

            foreach (var transporta in transportadoras)
            {
                Console.WriteLine(transporta.ToString());
            }


        }


    }
}

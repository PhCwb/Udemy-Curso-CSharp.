using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCadastro.Cadastro;
using TesteCadastro.Exceptions;
using TesteCadastro.Usuarios;

namespace TesteCadastro
{
    internal class Associacao
    {

        public CadastroDeMotorista CadastroDeMotorista { get; set; }
        public CadastroDeTransportadora CadastroDeTransportadora { get; set; }


        public List<Associacao> associacaos = new List<Associacao>();


        public void AddAssociacao(Associacao associacao)
        {
            associacaos.Add(associacao);
        }

        public void ListaDeAssociados()
        {
            if (associacaos.Count == 0)
            {
                throw new DomainsException("\u001b[31mNENHUM ASSOCIADO!\u001b[0m");
            }
            foreach (var associacao in associacaos)
            {
                Console.WriteLine(associacao.ToString());
            }
        }

    }
}

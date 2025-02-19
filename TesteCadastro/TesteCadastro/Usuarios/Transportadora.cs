using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCadastro.Usuarios
{
    internal class Transportadora
    {
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public DateTime DataDoCadastro { get; set; }

        public Transportadora(string nome, string logradouro, string bairro, string cidade)
        {
            Nome = nome;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            DataDoCadastro = DateTime.Now;
        }


        public override string ToString()
        {
            return
                $"CADASTRO DE TRANSPORTADORA:\n" +
                $"TRANSPORTADORA: {Nome}\n" +
                $"LOGRADOURO: {Logradouro}\n" +
                $"BAIRRO: {Bairro}\n" +
                $"CIDADE: {Cidade}\n" +
                $"DATA DO CADASTRO: {DataDoCadastro.ToString("d")}\n";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCadastro.Usuarios
{
    internal class Motorista
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public DateTime ValidadeCnh { get; set; }
        public DateTime DataDoCadastro { get; set; }

        public Motorista(string nome, string cpf, string cnh, DateTime validadeCnh)
        {
            Nome = nome;
            Cpf = cpf;
            Cnh = cnh;
            ValidadeCnh = validadeCnh;
            DataDoCadastro = DateTime.Now;
        }


        public override string ToString()
        {
            return 
                $"CADASTRO DO MOTORISTA: \n"+
                $"NOME: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"CNH: {Cnh}\n" +
                $"VALIDADE CNH: {ValidadeCnh.ToString("dd/MM/yyyy")}\n" +
                $"DATA DO CADASTRO: {DataDoCadastro.ToString("d")}\n";
        }




    }
}

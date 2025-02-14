using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeCadastro.Cadastro.CdMotorista
{
    internal class CadastroDeMotorista
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public DateTime ValidadeCnh { get; set; }
        public DateTime DataDoCadastro { get; set; }

        public CadastroDeMotorista(string nome, string cpf, string cnh, DateTime validadeCnh)
        {
            Nome = nome;
            Cpf = cpf;
            Cnh = cnh;
            ValidadeCnh = validadeCnh;
            DataDoCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Motorista: {Nome}" +
                $" CPF:{Cpf}" +
                $" CNH:{Cnh}" +
                $" Valida CNH:{ValidadeCnh.ToString("dd/MM/yyyy")}" +
                $" Data do cadastro: {DataDoCadastro.ToString("d")}";
        }

    }
}

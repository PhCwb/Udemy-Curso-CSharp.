using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeCadastro.Cadastro.CdVeiculo
{
    internal class CadastroDeVeiculo
    {
        public string MarcaDoVeiculo { get; set; }
        public string ModeloDoVeiculo { get; set; }
        public DateTime AnoDoVeiculo { get; set; }
        public string CorDoVeiculo { get; set; }
        public string PlacaDoCavalo { get; set; }
        public string PlacaDaCarreta { get; set; }
        public DateTime DataDoCadastroDoVeiculo { get; set; }

        public CadastroDeVeiculo(string marcaDoVeiculo, string modeloDoVeiculo, DateTime anoDoVeiculo, string corDoVeiculo, string placaDoCavalo, string placaDaCarreta)
        {
            MarcaDoVeiculo = marcaDoVeiculo;
            ModeloDoVeiculo = modeloDoVeiculo;
            AnoDoVeiculo = anoDoVeiculo;
            CorDoVeiculo = corDoVeiculo;
            PlacaDoCavalo = placaDoCavalo;
            PlacaDaCarreta = placaDaCarreta;
            DataDoCadastroDoVeiculo = DateTime.Now;
        }


        public override string ToString()
        {
            return $"Marca: {MarcaDoVeiculo}" +
                $"Modelo: {ModeloDoVeiculo}" +
                $"Ano: {AnoDoVeiculo.ToString("D")}" +
                $"Cor: {CorDoVeiculo}" +
                $"Placa do Cavalo: {PlacaDoCavalo}" +
                $"Placa da Carreta: {PlacaDaCarreta}" +
                $"Data do cadastro do Veiculo: {DataDoCadastroDoVeiculo.ToShortDateString()}";
        }
    }
}

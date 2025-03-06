using Exercicio136.Entities;
using System;
using System.Globalization;

namespace Exercicio136
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //C:\Users\phillype.alves\source\Arquivo Teste\doc.txt

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {


                //Lê todas as linhas do arquivo localizado no caminho sourceFilePath e as armazena no array lines
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);//Obtém o caminho da pasta onde o arquivo de entrada está localizado.
                string targetFolderPath = sourceFolderPath + @"\out";//Cria o caminho da pasta de saída, concatenando a pasta de origem com \out.
                string targetFilePath = targetFolderPath + @"\summary.csv";//Define o caminho completo do arquivo de saída, que será gerado como summary.csv dentro da pasta out

                Directory.CreateDirectory(targetFolderPath);//cria a pasta chamada (out)


                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    //Abre o arquivo summary.csv para escrita. O StreamWriter é usado para escrever texto no arquivo.
                    //O arquivo é aberto no modo de anexação (para adicionar conteúdo sem sobrescrever o existente).


                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');//Divide a linha em campos usando a vírgula como delimitador, criando um array fields contendo o nome, o preço e a quantidade.
                        string name = fields[0];//Atribui o nome do produto ao campo name.
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine($"{prod.Name} {prod.Total().ToString("C")}");
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
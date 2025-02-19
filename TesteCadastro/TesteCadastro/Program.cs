using System;
using TesteCadastro.Usuarios;
using TesteCadastro.Cadastro;
using System.Runtime.Serialization;
using TesteCadastro.Usuarios;
using TesteCadastro.Cadastro;

namespace TesteCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CadastroDeMotorista cadastroDeMotorista = new CadastroDeMotorista();
            CadastroDeTransportadora cadastroDeTransportadora = new CadastroDeTransportadora();

            char opcao;

            do
            {
                Console.Write("ESCOLHA A OPCAO: ");

                Console.Write(
                    "\n\u001b[35m[1]\u001b[0m CADASTRAR MOTORISTA.\n" +
                    "\u001b[35m[2]\u001b[0m CADASTRAR TRANSPORTADORA.\n" +
                    "\u001b[35m[3]\u001b[0m LISTA DE MOTORISTA CADASTRADO.\n" +
                    "\u001b[35m[0]\u001b[0m SAIR.\n" +
                    ">>> "
                );
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();

                try
                {

                    if (opcao == '1')
                    {
                        Console.Write("\n\u001b[35m[1]\u001b[0m CADASTRAR MOTORISTA:\n");
                        Console.Write("NOME: ");
                        string nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("CNH: ");
                        string cnh = Console.ReadLine();
                        Console.Write("VALIDADE DA CNH: ");
                        DateTime validadeCnh = DateTime.Parse(Console.ReadLine());

                        Motorista motorista = new Motorista(nome, cpf, cnh, validadeCnh);
                        cadastroDeMotorista.AddCadastroDeMotorista(motorista);

                        Console.WriteLine("\n\u001b[32m*MOTORISTA CADASTRADO COM EXITO!\u001b[0m\n");


                        Console.Write("DESEJA VOLTAR AO MENU INICIAL (S/N)?");
                        char voltarMenu = char.Parse(Console.ReadLine());

                        if (voltarMenu == 'n' || voltarMenu == 'N')
                        {
                            Console.Clear();
                            break;
                        }
                        else { Console.Clear(); }


                    }
                    else if (opcao == '2')
                    {
                        Console.Write("\n\u001b[35m[2]\u001b[0m CADASTRAR TRANSPORTADORA:\n");
                        Console.Write("NOME DA TRANSPORTADORA: ");
                        string nomeTransportadora = Console.ReadLine();
                        Console.Write("LOGRADOURO: ");
                        string logradouro = Console.ReadLine();
                        Console.Write("BAIRRO: ");
                        string bairro = Console.ReadLine();
                        Console.Write("CIDADE: ");
                        string cidade = Console.ReadLine();

                        Transportadora transportadora = new Transportadora(nomeTransportadora, logradouro, bairro, cidade);
                        cadastroDeTransportadora.AddCadastroDeTransportadora(transportadora);

                        Console.WriteLine("\n\u001b[32m*TRANSPORTADORA CADASTRADA COM EXITO!\u001b[0m\n");

                        Console.Write("DESEJA VOLTAR AO MENU INICIAL (S/N)?");
                        char voltarMenu = char.Parse(Console.ReadLine());

                        if (voltarMenu == 'n' || voltarMenu == 'N')
                        {
                            Console.Clear();
                            break;
                        }
                        else { Console.Clear(); }

                    }
                    else if (opcao == '3')
                    {
                        cadastroDeMotorista.ListaDeMotorista();
                    }
                    else if (opcao == '0')
                    {
                        Console.Clear();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }while (opcao != '0');



            //ajustes
            //add try e catch
            //Cadastro de veiculo, transportadora, viagem...
            //Associacao de veiculos com transportadora e motorista



            //switch (opcao)
            //{
            //    case '1':
            //        Console.Write("\n\u001b[35m[1]\u001b[0m CADASTRAR MOTORISTA.\n");
            //        Console.Write("NOME: ");
            //        string nome = Console.ReadLine();
            //        Console.Write("CPF: ");
            //        string cpf = Console.ReadLine();
            //        Console.Write("CNH: ");
            //        string cnh = Console.ReadLine();
            //        Console.Write("VALIDADE DA CNH: ");
            //        DateTime validadeCnh = DateTime.Parse(Console.ReadLine());

            //        Motorista motorista = new Motorista(nome, cpf, cnh, validadeCnh);
            //        cadastroDeMotorista.AddCadastroDeMotorista(motorista);

            //        Console.WriteLine("\n\u001b[32m*MOTORISTA CADASTRADO COM EXITO!\u001b[0m\n");

            //        Console.WriteLine(motorista.ToString());

            //        break;
            //    case '2':
            //        //Listagem de motorista.//Pasta(Cadastro) > Class(CadastroDeMotorista)
            //        cadastroDeMotorista.ListaDeMotorista();
            //        break;
            //    case '3':
            //    default:
            //        Console.Clear();
            //        break;


            //}









        }
    }
}

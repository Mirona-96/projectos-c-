using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleat = new Random();
            CultureInfo culture = CultureInfo.InvariantCulture;

            int numeroConta = aleat.Next(10000, 99999); //atribui o numero de conta

            Console.Write("\nInforme o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("\nPretende fazer um  depósito inicial? (s/n): ");
            char opcao = char.Parse(Console.ReadLine());
            double deposito = 0;
            double saldoConta = 0;

            int nib = aleat.Next(10000000, 99999999); //atribui o nib

            if (opcao == 's' || opcao == 's')
            {
             Console.Write("\nInsira o montante inicial a depositar: ");
             deposito = double.Parse(Console.ReadLine(), culture);
             saldoConta += deposito;
            }             

            Conta c = new Conta (numeroConta, nomeTitular, saldoConta, nib);
            Console.WriteLine("Dados da Conta: ");
            c.Imprimir();

            do
            {
                Console.Write("\nPretende efectuar outra transacao? (s/n): ");
                opcao = char.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a transacao: " +
                    "\n1. Deposito;" +
                    "\n2. Levantamento;" +
                    "\n3. Transferencia;" +
                    "\n4. Pagamentos de serviços" +
                    "\n0. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("\nInsira  o montante a depositar: ");
                        deposito = double.Parse(Console.ReadLine(), culture);
                        c.deposito(deposito);
                        break;

                    case 2:
                        Console.Write("\nInsira o montante a sacar: ");
                        double saque = double.Parse(Console.ReadLine(), culture);
                        c.saque(saque);
                        break;

                    case 3:
                        Conta contaDestino = new Conta();
                        Console.Write("\nInsira o numero da conta destino: ");
                        contaDestino.Nib = int.Parse(Console.ReadLine());
                        Console.Write("\nInsira o montante a transferir: ");
                        double valor = double.Parse(Console.ReadLine(), culture);
                        c.transferencia(valor, contaDestino);
                        break;

                    case 4:
                        Console.WriteLine("\nEscolha o serviço que pretende pagar: " +
                            "\n1. Agua;" +
                            "\n2. Energia;" +
                            "\n3. TV e Internet");

                        int servico = int.Parse(Console.ReadLine());

                        switch (servico)
                        {
                            case 1:
                                Console.WriteLine("Insira o montante a pagar: ");
                                valor = double.Parse(Console.ReadLine(), culture);
                                c.pgtoServico(valor);
                                break;

                            case 2:
                                Console.WriteLine("Insira o montante a pagar: ");
                                valor = double.Parse(Console.ReadLine(), culture);
                                c.pgtoServico(valor);
                                break;

                            case 3:
                                Console.WriteLine("Insira o montante a pagar: ");
                                valor = double.Parse(Console.ReadLine(), culture);
                                c.pgtoServico(valor);
                                break;

                            default:
                                Console.WriteLine("opcao invalida!");
                                break;
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

            } while (opcao == 's' || opcao == 's');



            Console.WriteLine("\nDados da conta actualizados!");
        }
    }
}

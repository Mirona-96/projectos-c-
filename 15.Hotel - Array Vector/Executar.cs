using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Hotel___Array_Vector
{
    class Executar
    {
        static void Main(string[] args)
                        
        {
            Hospede[] quartos = new Hospede[10]; 

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++) {
                Console.WriteLine("\nAluguer #:" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("opcao invalida. insira um numero entre 1 e 9.");
                    Console.Write("Quarto: ");
                    numQuarto = int.Parse(Console.ReadLine());
                } while (numQuarto < 0 || numQuarto > 10);
                
                if (quartos[numQuarto] != null)
                {
                    Console.WriteLine("Quarto ocupado");
                    i--; //volta para aluguer anterior
                } 
                else
                {
                    quartos[numQuarto] = new Hospede(nome, email, numQuarto);
                    Console.WriteLine("Alguer realizado com sucesso!");
                }   

            }

            Console.Clear();
            Console.Write("\nQuartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.Write("\n" + (i + 1) + ":");
                    quartos[i].Imprimir();

                }
            }

        }
    }
}

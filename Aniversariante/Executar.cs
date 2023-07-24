using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversariante
{
    class Executar
    {
        static void Main(string[] args)
        {
            Console.Write("insira o id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("introduza o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("insira a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Pessoa p = new Pessoa(id, nome, idade);

            

            Console.WriteLine();

            p.CompletarAniversario();
            p.CompletarAniversario();
            p.CompletarAniversario();

            p.imprimir();

        }
    }
}

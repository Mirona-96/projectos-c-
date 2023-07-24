using IdadeMaior;
using System;

class Program
{
 
    static void Main(string[] args)
    {

        Pessoa[] pessoas = new Pessoa[2]; 
        
        for (int i = 0; i<pessoas.Length; i++)
        {
           pessoas[i] = new Pessoa();

            Console.WriteLine("\ninsira o " + (i+1) + ".o nome: ");
            pessoas[i].nome = Console.ReadLine();

            Console.WriteLine("insira a idade da " +(i+1) + ".a pessoa: ");
            pessoas[i].idade = int.Parse(Console.ReadLine());
            
         }

        Console.Clear();

        for (int i = 0; i<pessoas.Length; i++)
        {
            Console.WriteLine("\nDados da " + (i+1) + ".a pessoa: " +
                "\nNome: " + pessoas[i].nome + 
                "\nIdade:" + pessoas[i].idade);
        }

        Pessoa p = new Pessoa();
        int maior = p.idadeMaior(pessoas[0].idade, pessoas[1].idade);
        
        for (int i = 0; i<2; i++)
        {
            if (maior == pessoas[i].idade){
                Console.WriteLine("\nA pessoa mais velha é " + pessoas[i].nome);
            }
        }
        
    }
}
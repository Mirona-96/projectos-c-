using System;
using System.Globalization; //Para CultureInfo

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com o seu nome: ");
        String[] nomeCompleto = Console.ReadLine().Split(' ');
        String nome1 = nomeCompleto[0];
        String nome2 = nomeCompleto[1];

        Console.WriteLine("Quantos quartos tem na sua casa: ");
        int numquarto = (Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Entre com o preco do Produto: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com o seu ultimo nome, idade e altura: ");
        String[] NomIdAl = Console.ReadLine().Split(' ');
        String ultimoNome = NomIdAl[0];
        int idade = (Convert.ToInt32(NomIdAl[1]));
        double altura = double.Parse(NomIdAl[2], CultureInfo.InvariantCulture);

        double CalcPreco = numquarto * preco;

        Console.Clear();

        Console.WriteLine("nome completo: " + nome1 + " " +nome2);
        Console.WriteLine("numero de quartos " + numquarto);
        Console.WriteLine("o preco do produto e de " + preco);
        Console.WriteLine("ultimo nome: " + ultimoNome);
        Console.WriteLine("idade: " + idade);
        Console.WriteLine("altura: " + altura);
        Console.WriteLine("preco e " + CalcPreco.ToString ("F2"));

    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double preco = 0.00;
        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.Write("insira a o codigo do produto: \n" +
            "1. REFRESCO ....................... 20,00 MT \n" + 
            "2. Sandes de Ovo .................. 60,00 MT \n" + 
            "3. Chamussas ...................... 35,00 MT \n" +
            "4. Biscoito ....................... 25,00 MT \n" + 
            "5. Hamburguer .....................120,00 MT \n");
        int codigo = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Insira a quantidade do produto: ");
        int qtd = Convert.ToInt32(Console.ReadLine());
        

            if (codigo == 1)
             {
            Console.Write("Escolheu refresco \n");
            preco = 20.00;
            }else if (codigo == 2)
            {
            Console.Write("Escolheu sandes de ovo \n");
            preco = 60.00;
            } else if (codigo == 3)
        {
            Console.Write("Escolheu chamussas \n");
            preco = 35.00;
        } else if(codigo == 4)
        {
            Console.Write("Escolheu biscoitos \n");
            preco = 35.00;

        } else if (codigo == 5)
        {
            Console.Write("Escolheu hamburguer \n");
            preco = 120.00;

        } else
        {
            Console.Write("opcao invalida \n");
            preco = 00.00;
        }

        double totalCompra = preco * qtd;
        Console.WriteLine ("total a pagar: " + totalCompra.ToString("F2"),culture + " MZN");

     }
}
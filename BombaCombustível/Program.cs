using System;

class Program
{
    static void Main(string[] args)
    {
        int alcool = 0, gasolina = 0, diesel = 0, codigo = 0;        
        
        do
        {
            Console.Write("\ninsira o codigo do combustive: \n" +
            "1. Alcool \n" +
            "2. Gasolina \n" +
            "3. Diesel \n" +
            "4. Fim \n");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Fora da faixa");
                    break;
            }

        } while (codigo!=4);

        Console.WriteLine("\nMUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina " + gasolina);
        Console.WriteLine("Diesel " + diesel);
    }
}


        
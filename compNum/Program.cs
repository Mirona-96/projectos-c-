using System;

class compNump
{
    static void Main(string[] args)
    {
        double a = 1.964785;
        double b = 3.478236;
        double p = 0.000001;



        if (b > a)
        {
            Console.WriteLine(b + " eh maior que " + a);
        } else
        {
            Console.WriteLine(a + " eh maior que " + b);
        }

        //calcula o valor absoluto da diferenca de a e b
        if (Math.Abs (a - b) < p)
        {
            Console.WriteLine(a + " e " + b + " sao iguais");
        } else
        {
            Console.WriteLine(a + " e " + b + " sao diferentes");
        }

    }
}


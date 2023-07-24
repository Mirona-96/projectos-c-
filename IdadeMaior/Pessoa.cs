using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeMaior
{
    class Pessoa
    {
        public String nome;
        public int idade;

        public int idadeMaior(int idade1, int idade2)
        {
            int maior = 0;

            if (idade1 > idade2)
            {
                maior = idade1;
            }
            else
            {
                maior = idade2;
            }
            return maior;
        }

    }
}

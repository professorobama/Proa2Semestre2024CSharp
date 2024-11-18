using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proa2Semestre2024
{
    internal class Exemplo01If
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("O número digitado é menor que o número 10");
            }
        }
    }
}

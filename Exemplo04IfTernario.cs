using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proa2Semestre2024
{
    internal class Exemplo04IfTernario
    {
        public static void Main(string[] args) {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt16(Console.ReadLine());
            string mensagem = (numero < 10) ? "Número menor que 10" : "Número menor que 10";
            Console.WriteLine(mensagem);
        }
    }
}

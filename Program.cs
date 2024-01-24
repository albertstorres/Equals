using System;
namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Texto de teste";
            Console.WriteLine(texto.Equals("Texto"));
            Console.WriteLine(texto.Equals("texto de teste"));
            Console.WriteLine(texto.Equals("Texto de teste"));
        }
    }
}

using System;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            //Concatenação
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            //Interpolação.
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
        }
    }
}
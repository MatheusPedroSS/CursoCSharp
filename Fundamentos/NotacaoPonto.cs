using System;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá"
                            .ToUpper()
                            .Insert(3, " World!")
                            .Replace("World!", "Mundo!");

            System.Console.WriteLine(saudacao);

            System.Console.WriteLine("Teste".Length);

            // Navegação Segura
            string valorImportante = null;
            System.Console.WriteLine(valorImportante?.Length);
        }
    }
}
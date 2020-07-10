using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int númerointeiro;
            int i = 1;
            int resultado = 1;
            bool terminar = false;
            while (!terminar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Insira um número inteiro e veja seu fatorial.");
                bool númerobool = Int32.TryParse(Console.ReadLine(), out númerointeiro);
                int númerofinal = númerointeiro;
                int salvamento = númerointeiro;
                if (!númerobool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                    Console.ReadKey();
                }
                else  
                {
                    while (i <= númerointeiro)
                    {
                        resultado = resultado * salvamento;
                        salvamento--;
                        i++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{númerofinal}! = {resultado}");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para finalizar o programa");
                    Console.ReadKey();
                    terminar = true;
                }

            }
        }
    }
}

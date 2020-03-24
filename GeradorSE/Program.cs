using System;
using System.Collections.Generic;

namespace GeradorSE
{
    class Program
    {
        private Dictionary<string, bool?> Variables { get; set; } = new Dictionary<string, bool?>();

        private Dictionary<string, bool?> Objectives { get; set; } = new Dictionary<string, bool?>(); 

        public List<string> Rules { get; set; } = new List<string>();

        static void Main(string[] args)
        {
            var variables = new Dictionary<string, bool?>();
            var objectives = new Dictionary<string, bool?>();
            var rules = new List<string>();

            Console.WriteLine("BEM VINDO AO GERADOR DE SISTEMAS ESPECIALISTAS");
            Console.WriteLine("\nDigite uma regra para o sistema e aperte ENTER" +
                "\nDigite a regra no seguinte formato: 'SE ... ENTÂO ...'" +
                "\nQuando terminar de inserir as regras, aperte ESC");
            Console.WriteLine("\n");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                rules.Add(Console.ReadLine());
            }

            Console.WriteLine("Digite o nome da variável e aperte ENTER" +
                "\nEm seguida, digite o valor da variável e aperte ENTER" +
                "\nQuando terminar, aperte ESC");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                variables.Add(Console.ReadLine(), Console.ReadLine().ToBoolean());
            }

            Console.WriteLine("Digite o nome da objetivo e aperte ENTER" +
                "\nEm seguida, digite o valor da objetivo (Sim ou Não) e aperte ENTER" +
                "\nQuando terminar, aperte ESC");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                objectives.Add(Console.ReadLine(), Console.ReadLine().ToBoolean());
            }
        }
    }
}

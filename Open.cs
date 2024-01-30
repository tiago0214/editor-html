using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Open
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("------------");
            Abrir();

        }
        public static void Abrir()
        {
            //Console.Clear();
            Console.WriteLine("Qual o caminho que deseja abrir? ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.Clear();
                string texto = file.ReadToEnd();
                Viewer.Show(texto);
            }
            Console.ReadLine();
            Menu.Show();
        }
    }
}
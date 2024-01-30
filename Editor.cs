using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            string textoConvertido = file.ToString();

            Console.WriteLine("------------");
            Console.WriteLine("Deseja salvar o arquivo ? Sim ou não");
            string salvar = Console.ReadLine();

            if (salvar.ToLower() == "sim")
                Salvar(textoConvertido);
            else
            {
                //alterar aqui a chamada da função -> para apontar para o viewer
                Viewer.Show(textoConvertido);
                Console.WriteLine("Obrigado por usar o programa. ");
                Console.WriteLine("Precione qualquer tecla para sair. ");
                Console.ReadKey();
                Menu.Show();
            }
        }

        public static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(texto);
            }
            Console.WriteLine("Arquivo salvo com sucesseo");
            Console.WriteLine("Precione qualquer tecla para sair. ");
            Console.ReadLine();
            Menu.Show();
        }

    }
}
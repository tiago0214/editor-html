using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO HTML");
            Console.WriteLine("------------");
            Replace(text);
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            var blue = new Regex(@$"<\s*blue[^>]*>(.*?)<\s*/\s*blue>");
            var red = new Regex(@$"<\s*red[^>]*>(.*?)<\s*/\s*red>");
            var green = new Regex(@$"<\s*green[^>]*>(.*?)<\s*/\s*green>");
            var yellow = new Regex(@$"<\s*yellow[^>]*>(.*?)<\s*/\s*yellow>");
            var words = text.Split(" ");


            for (int i = 0; i < words.Length; i++)
            {
                if (blue.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else if (red.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else if (green.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else if (yellow.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            Option();

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Coluns();
            Lines();
            Coluns();

        }
        public static void Coluns()
        {
            Console.Write("+");
            for (int coluns = 0; coluns < 65; coluns++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void Lines()
        {
            for (int lines = 0; lines < 20; lines++)
            {
                Console.Write("|");
                for (int coluns = 0; coluns < 65; coluns++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void Option()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo!");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Open.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Show(); break;
                    }

            }
        }

    }
}
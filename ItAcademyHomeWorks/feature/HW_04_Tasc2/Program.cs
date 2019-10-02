using System;

namespace HW_04_Tasc2
{
    class Program
    {
       
            static int OffsetX = 20;
            static int OffsetY = 3;

            public static void firstDraw(char[,] map) //Очищает и рендерит карту;
            {
                Console.Clear();
                for (int y = 0; y < 5; y++)
                    for (int x = 0; x < 7; x++)
                        putCh(map[y, x], y, x);
            }

            private static void putCh(char ch, int y, int x)
            {
                Console.SetCursorPosition(OffsetX + x, OffsetY + y);
                Console.Write(ch);
            }

            static char[,] map =
                {
                {'#','#','#','#','#','#','#'},
                {'#','.','.','.','.','.','#'},
                {'#','.','.','.','.','.','#'},
                {'#','.','.','.','.','.','#'},
                {'#','#','#','#','#','#','#'}
            };

            static int heroX = 3; //Задаем координаты персонажа
            static int heroY = 2;

        static void Main(string[] args)
        {
            map[heroY, heroX] = '@'; //Ставим персонажа на карту
            firstDraw(map); //Рендерим

            ConsoleKeyInfo keypress;
            do
            {
                keypress = Console.ReadKey(true);
                switch (keypress.KeyChar)
                {
                    case 'w': move(0, -1); break;
                    case 's': move(0, 1); break;
                    case 'd': move(1, 0); break;
                    case 'a': move(-1, 0); break;
                    default:
                        break;
                }
            } while (keypress.KeyChar != 'q');
        }

        private static void move(int dx, int dy)
        {

            if (map[heroY + dy, heroX + dx] == '#') return; //Провяем нет ли стены там, куда мы будем двигаться
            map[heroY, heroX] = '.';
            putCh('.', heroY, heroX);
            heroY += dy; heroX += dx;
            map[heroY, heroX] = '@';
            putCh('@', heroY, heroX);
        }

    }
}

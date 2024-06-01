using System.ComponentModel.Design;
using System.Text;

namespace FileManager_Popova_POB2312
{
    class Program
    {
        private const int WINDOW_WIDTH = 120;
        private const int WINDOW_HEIGHT = 40;
        private static string _currentDir = Directory.GetCurrentDirectory();
        public static void Main(string[] args)
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            DirectoryInfo dir = new DirectoryInfo(_currentDir);
            _currentDir = dir.Root.FullName;

            DrawConsole(0, 0, WINDOW_WIDTH, 25);
            DrawConsole(0, 25, WINDOW_WIDTH, 8);

            UpdateConsole();
        }
        public static void UpdateConsole()
        {
            DrawInputCommandField(_currentDir, 0, 35, WINDOW_WIDTH, 3);

            CommandInputProcess();
        }

        public static void CommandParser(string command)
        {
            string[] commandParts=command.Split(" ");

            switch (commandParts[0])
            {
                case "cd":
                    
                    if (commandParts.Length==1)
                    {
                        _currentDir = new DirectoryInfo(_currentDir).Root.FullName;
                    }
                    else if(commandParts.Length==2) 
                    {
                        if (commandParts[1]=="..")
                        {
                            _currentDir = new DirectoryInfo(_currentDir).Parent.FullName;
                            
                        }
                        else if(commandParts[1] == "\\")
                        {
                            if (Directory.Exists(commandParts[1]))
                            {
                                _currentDir = commandParts[1];
                            }
                        }
                        else 
                        {
                            if (Directory.Exists(_currentDir + commandParts[1]))
                            {
                                _currentDir = commandParts[1];

                            }
                        }
                    }
                    break;
            }

            UpdateConsole();
        }
        public static void CommandInputProcess()
        {
            StringBuilder command = new StringBuilder();

            char pressedKey;

            int savedLeftPosision = Console.CursorLeft;

            do
            {
                pressedKey = Console.ReadKey().KeyChar;

                ConsoleKey key = (ConsoleKey)pressedKey;
                int left = Console.CursorLeft;
                int top = Console.CursorTop;

                if (key == ConsoleKey.Backspace)
                {


                    if (left < savedLeftPosision)
                    {
                        Console.Write("$");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(left, top);

                        command.Remove(command.Length - 1, 1);
                    }
                }

                else if (left == WINDOW_WIDTH - 2)
                {
                    Console.SetCursorPosition(left - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(left - 1, top);
                }
                else
                {
                    command.Append(pressedKey);
                }

            }
            while ((ConsoleKey)pressedKey != ConsoleKey.Enter);

            command.Remove(command.Length-1, 1);

            CommandParser(command.ToString());

        }

        public static void DrawInputCommandField(string currentDir, int left, int top, int width, int height)
        {
            DrawConsole(left, top, width, height);

            Console.SetCursorPosition(1, 34);
            Console.Write($"{currentDir}$");

        }

        public static void DrawConsole(int left, int top, int width, int height)
        {
            Console.SetCursorPosition(left, top);

            Console.Write("┌");
            for (int j = 0; j < width - 2; j++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┐");

            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("│");
                for (int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("│");
            }

            Console.Write("└");
            for (int j = 0; j < width - 2; j++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┘");
        }
    }
}
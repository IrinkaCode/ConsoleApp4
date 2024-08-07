﻿using System;
using System.Text;

namespace FileManager_Popova_POB2312
{
    class Program
    {
        private const int WINDOW_WIDTH = 120;
        private const int WINDOW_HEIGHT = 40;
        private static string _currentDir = Directory.GetCurrentDirectory();
        private static string _tree = "";

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
            DrawInputCommandField(_currentDir, 0, 33, WINDOW_WIDTH, 3);

            CommandInputProcess();
        }

        public static void DrawTree(int page, string startPath)
        {
            DirectoryInfo startDir = new DirectoryInfo(startPath);
            GetTree(startDir, "", true);

            DrawConsole(0, 0, WINDOW_WIDTH, 25);

            string[] lines = _tree.Split('\n');

            int linesAtPage = 23;
            int pagesQuantity = (int)Math.Ceiling(lines.Length / (double)linesAtPage);

            string[,] pages = new string[pagesQuantity, linesAtPage];

            if (lines.Length >= linesAtPage)
            {
                for (int i = 0; i < pages.GetLength(0); i++)
                {
                    int cell = 0;
                    for (int j = linesAtPage * i; j < linesAtPage * (i + 1); j++)
                    {
                        if (lines[j] == "")
                        {
                            break;
                        }

                        pages[i, cell] = lines[j];
                        cell++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < pages.GetLength(0); i++)
                {
                    int cell = 0;
                    for (int j = linesAtPage * i; j < lines.Length; j++)
                    {
                        pages[i, cell] = lines[j];
                        cell++;
                    }
                }
            }

            for (int i = 0; i < pages.GetLength(1); i++)
            {
                Console.SetCursorPosition(1, i + 1);
                Console.WriteLine(pages[page - 1, i]);
            }

            string currentPage = $"[ {page} / {pages.GetLength(0)} ]";
            Console.SetCursorPosition(WINDOW_WIDTH / 2 - currentPage.Length / 2, 25);
            Console.WriteLine(currentPage);

            _tree = string.Empty;
        }

        public static void GetTree(DirectoryInfo currentDir, string indent, bool lastDirectory)
        {
            _tree += indent;

            if (lastDirectory)
            {
                _tree += "└──";
                indent += "   ";
            }
            else
            {
                _tree += "├──";
                indent += "│  ";
            }

            _tree += currentDir.Name + '\n';

            DirectoryInfo[] subDirectories = currentDir.GetDirectories();
            for (int i = 0; i < subDirectories.Length; i++)
            {
                GetTree(subDirectories[i], indent, i == subDirectories.Length - 1);
            }
        }

        public static void CommandParser(string command)
        {
            string[] commandParts = command.Split(" ");

            switch (commandParts[0])
            {
                case "cd":
                    if (commandParts.Length == 1)
                    {
                        _currentDir = new DirectoryInfo(_currentDir).Root.FullName;
                    }
                    else if (commandParts.Length == 2)
                    {
                        if (commandParts[1] == "..")
                        {
                            _currentDir = new DirectoryInfo(_currentDir).Parent.FullName;
                        }
                        else if (commandParts[1].Contains('\\'))
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
                                _currentDir += commandParts[1];

                                Console.SetCursorPosition(0, 0);
                            }
                        }
                    }
                    break;
                case "tree":
                    if (commandParts.Length == 1)
                    {
                        DrawTree(1, _currentDir);
                    }
                    else if (commandParts.Length == 3)
                    {
                        if (commandParts[1] == "-p")
                        {
                            DrawTree(int.Parse(commandParts[2]), _currentDir);
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

            int savedLeftPosition = Console.CursorLeft;

            do
            {
                pressedKey = Console.ReadKey().KeyChar; // Символ, который ввели

                ConsoleKey key = (ConsoleKey)pressedKey; // И значение клавиши, которую нажали

                int left = Console.CursorLeft;
                int top = Console.CursorTop;

                if (key == ConsoleKey.Backspace)
                {
                    if (left < savedLeftPosition)
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
                else if (left == WINDOW_WIDTH - 1)
                {
                    Console.SetCursorPosition(left - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(left - 1, top);
                }
                else
                {
                    command.Append(pressedKey);
                }

            } while ((ConsoleKey)pressedKey != ConsoleKey.Enter);

            command.Remove(command.Length - 1, 1);

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

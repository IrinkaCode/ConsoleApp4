//Этот код создает консольную игру "крестики-нолики" на C#. Игроки по очереди вводят координаты клетки, чтобы поставить свой символ (X или O). Побеждает игрок, который сможет выстроить три своих символа в ряд по вертикали, горизонтали или диагонали. Игра продолжается до победы одного из игроков или до ничьей.

int[][] mas = new int[3][];
mas[0] = new int[] { 1, 2, 3 };
mas[1] = new int[] { 4, 5, 6 };
mas[2] = new int[] { 7, 8, 9 };
char[,] board=new char[3, 3];
bool player1 = true;
char currentPlayer = 'X';
int moves = 0;

Console.WriteLine(" | | ");
Console.WriteLine("-----");
Console.WriteLine(" | | ");
Console.WriteLine("-----");
Console.WriteLine(" | | ");

while (true)
{
    Console.Clear();
    PrintBoard(board);

    int player = player1 ? 1 : 2;
    Console.Write($"Игрок {player} выберите номер ячейки: ");
    int numberUser = int.Parse(Console.ReadLine());

    int row = (numberUser - 1) / 3;
    int col = (numberUser - 1) % 3;

    if (board[row, col] != '\0')
    {
        Console.WriteLine("Ячейка уже занята. Попробуйте еще раз.");
        continue;
    }

    board[row, col] = currentPlayer;
    moves++;

    if (CheckWin(board, currentPlayer))
    {
        Console.Clear();
        PrintBoard(board);
        Console.WriteLine($"Игрок {player} победил!");
        break;
    }

    if (moves == 9)
    {
        Console.Clear();
        PrintBoard(board);
        Console.WriteLine("Ничья!");
        break;
    }

    player1 = !player1;
    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
}
    
void PrintBoard(char[,] board)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j] == '\0' ? " |" : $"{board[i, j]}|");
        }
        Console.WriteLine("\n-----");
    }
}

bool CheckWin(char[,] board, char player)
{
    // Проверка по горизонтали
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
            return true;
    }

    // Проверка по вертикали
    for (int i = 0; i < 3; i++)
    {
        if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
            return true;
    }

    // Проверка по диагонали
    if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
        (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
        return true;

    return false;
}





//готовый вариант
//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9 };

//char[,] board = new char[3, 3];
//bool player1Turn = true;
//char currentPlayer = 'X';

//while (true)
//{
//    Console.Clear();
//    DrawBoard(board);

//    int player = player1Turn ? 1 : 2;
//    Console.Write("Игрок " + player + " выберите номер клетки: ");
//    int number = int.Parse(Console.ReadLine());

//    int row = (number - 1) / 3;
//    int col = (number - 1) % 3;

//    if (board[row, col] == '\0')
//    {
//        board[row, col] = currentPlayer;

//        if (CheckWin(board, currentPlayer))
//        {
//            Console.Clear();
//            DrawBoard(board);
//            Console.WriteLine("Игрок " + player + " победил!");
//            break;
//        }

//        if (CheckDraw(board))
//        {
//            Console.Clear();
//            DrawBoard(board);
//            Console.WriteLine("Ничья!");
//            break;
//        }

//        player1Turn = !player1Turn;
//        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//    }
//    else
//    {
//        Console.WriteLine("Эта клетка уже занята, выберите другую.");
//    }
//}


//    static void DrawBoard(char[,] board)
//{
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            Console.Write(board[i, j] == '\0' ? " |" : board[i, j] + "|");
//        }
//        Console.WriteLine();
//        if (i < 2)
//        {
//            Console.WriteLine("------");
//        }
//    }
//}

//static bool CheckWin(char[,] board, char player)
//{
//    for (int i = 0; i < 3; i++)
//    {
//        if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
//        {
//            return true;
//        }
//        if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
//        {
//            return true;
//        }
//    }

//    if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
//    {
//        return true;
//    }
//    if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
//    {
//        return true;
//    }

//    return false;
//}

//static bool CheckDraw(char[,] board)
//{
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            if (board[i, j] == '\0')
//            {
//                return false;
//            }
//        }
//    }
//    return true;
//}
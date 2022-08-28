namespace Battleships
{
    class programm
    {
        public static void Main()
        {
            char[,] board = { { 'X', 'X', '.', 'X' }, 
                              { '.', '.', '.', 'X' }, 
                              { '.', '.', '.', 'X' } };
            Console.WriteLine(CountBattleships(board)); //output: 2

            char[] board2 = { '.' };
            Console.WriteLine(CountBattleships(board2)); //output: 0

            char[,] board3 = { { 'X', '.', '.', 'X' },
                               { '.', '.', '.', '.' },
                               { '.', 'X', '.', 'X' },
                               { '.', '.', '.', 'X' } };
            Console.WriteLine(CountBattleships(board3)); //output: 4

            char[,] board4 = { { 'X', '.', '.', 'X' },
                               { '.', 'X', '.', '.' },
                               { '.', '.', '.', 'X' },
                               { '.', 'X', '.', 'X' } };
            Console.WriteLine(CountBattleships(board4)); //output: 5

            char[] board5 = { 'X', 'X', '.', '.', 'X' };
            Console.WriteLine(CountBattleships(board5)); //output: 2
        }
        static int CountBattleships(char[,] board)
        {
            int count = 0;
            string skipList="";
            for(int i =0; i < board.GetLength(0); i++)
            {
                for(int j=0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'X' && !skipList.Contains(i.ToString() + j.ToString())) // обнаружение корабля
                    {
                        count++;
                        
                        //сканирование тела корабля
                        while(j < board.GetLength(1) - 1 && board[i, j + 1] == 'X') //если есть тело по горизонтали прыгаем на след позицию
                        {
                            j++;
                        }
                        int dec = 0;
                        while (i < board.GetLength(0) - 1 && board[i+1, j] == 'X') //если есть тело по вертикали прыгаем на след позицию по вертикали вниз
                        {
                            i++;
                            skipList += i.ToString() + j.ToString() + ",";  // список тела корабля, что бы не добавлялся новый корабль.
                            dec++;
                        }
                        i = i - dec;                                        // перемещаемся в основной цикл
                    }
                }
            }
            return count;
        }
        static int CountBattleships(char[] board)
        {
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {

                if (board[i] == 'X')
                {
                    count++;
                    while (i < board.Length - 1 && board[i + 1] == 'X')
                    {
                        i++;
                    }

                }
            }
            return count;
        }

    }
}

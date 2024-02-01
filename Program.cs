internal class Program
{
    private static void Main(string[] args)
    {
        int[,] macierz = new int[10, 10]; // two-dimensional array/matrix 400bytes
        int sum = 0;
        for (int i = 0; i < 10; i++)// 10 rows each
        {
            for (int j = 0; j < 10; j++) // 10 columns 
            {
                if (i == j)
                {
                    // numbers on the diagonal: remainder of the division of the number "i" by 10 => 0to9
                    macierz[i, j] = i % 10;
                    sum += i;
                }
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(macierz[i, j] + " ");//displaying items in one row
            }
            Console.WriteLine();// moving to the next line to display next rows like matrix
        }
        Console.WriteLine($"Sum of numbers on diagonal= {sum} ");
    }
}


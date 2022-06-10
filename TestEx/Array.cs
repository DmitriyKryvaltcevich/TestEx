
namespace TestEx
{
    class ArrayCW 
    {
        public int[,] arr = { { 1, 2, 3, 4, 9, 7 }, { 5, 6, 7, 8, 1, 8 }, { 9, 8, 7, 6, 3, 1 }, { 5, 4, 3, 2, 5, 9 }, { 1, 4, 3, 9, 4, 5 }, { 1, 7, 5, 3, 1, 9 } };
        public void calcCW()
        {
            Console.WriteLine("1. Массив:");
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write($" { arr[i, j] } ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class Array1A : ArrayCW
    {
        //1.a
        public void calcArr()
        {
            int diagonal = 0;
            int sum = 0;
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (j == diagonal)
                    {
                        sum += arr[i, j];
                        diagonal++;
                        break;
                    }
                }
            }
            Console.WriteLine($"a: сумма чисел главной диагонали = {sum}");
        }
    }
    class Array1B : ArrayCW
    {
        //1.b
        public void calcArr()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] % 3 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"b: сумма чисел кратных 3 = {sum}");
            Console.WriteLine();
        }
    }
}
    



namespace TestEx
{
    class RecFunc
    {
        int numcheck(string? tmp)
        {
            if (!int.TryParse(tmp, out int num))
            {
                Console.WriteLine("Введите целое цисло: ");

                num = numcheck(Console.ReadLine());
                return num;
            }
            else return num;
        }
        public void _fibcalc()
        {
            Console.WriteLine("2 а: Введите номер числа из последовательности Фибоначчи: ");
            string? tmp = Console.ReadLine();
            int num = numcheck(tmp);
            Console.WriteLine($"Число = {Fibcalc(num)} (цикл)");
            Console.WriteLine($"Число = {fibcalc(num)} (рекурсия)");
            Console.WriteLine();
        }
        public void _pow()
        {
            Console.WriteLine("2 b: Введите число: ");
            string? tmp = Console.ReadLine();
            Console.WriteLine("Введите степень: ");
            string? tmp1 = Console.ReadLine();
            int num = numcheck(tmp);
            int num1 = numcheck(tmp1);
            Console.WriteLine($"Число = {Pow(num, num1)}");
            Console.WriteLine($"Число = {pow(num, num1)} (рекурсия)");
            Console.WriteLine();
        }
        int fibcalc(int num)
        {
            int fib(int n1, int n2, int n)
            {
                if (n == 0) return n;
                else return n == 1 ? n1 : fib(n2, n1 + n2, n - 1);
            }
            return fib(0, 1, num);
        }
        int Fibcalc(int num, int n1 = 0, int n2 = 1)
        {
            if (num <= 1) return n1;
            int n;
            for (int j = 2; j < num; j++)
            {
                n = n1;
                n1 = n2;
                n2 = n2 + n;
            }
            return n2;
        }
        double pow(int num1, int num2)
        {
            {
                if (num2 < 0) return 1 / pow(num1, -num2);
                else return num2 == 0 ? 1 : pow(num1, num2 - 1) * num1;
            }
        }
        double Pow(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
    


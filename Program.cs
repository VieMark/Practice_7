namespace Practice_7;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        string str = "qwertyuio";
        int [] massiv = {1, 2, 3, 54, 11, 6, 19, 0, 8};
        int count = massiv.Count();

        Console.WriteLine($"Задание 1: {Factorial(a)}");

        Console.WriteLine($"Задание 3: {Str_Reverse(str)}");
        Console.WriteLine($"Задание 4: {Sum_massiv(massiv, count)}");
    }

    static int Factorial(int a)
    {
        if (a == 1){
            return 1;
        }
        return a * Factorial(a - 1);
    }



    static string Str_Reverse(string str)
    {
        int len = str.Length;
        string res = "";
        if (len > 1)
        {           
            // Substring возвращает новую строку  str.Substring(от, до)
            res = str[len - 1] + Str_Reverse(str.Substring(0, len - 1));
            return res;
        }
        else
            return str;
    }
    static int Sum_massiv(int [] massiv, int count)
    {
        if (count == 0)
        {
            return 0;
        }
        else
        {
            return massiv[count-1]+Sum_massiv(massiv, count-1);
        }
    }
}

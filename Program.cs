namespace Practice_7;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        string str = "qwertyuio";
        int [] massiv = {1, 2, 3, 54, 11, 6, 19, 0, 8};
        int count = massiv.Count();
        

        //
        Console.WriteLine("Задачи из Tasks");
        Console.WriteLine($"Задание 1: {Factorial(a)}");

        Console.WriteLine($"Задание 3: {Str_Reverse(str)}");
        Console.WriteLine($"Задание 4: {Sum_massiv(massiv, count)}");
        Console.WriteLine("Задание 5 :");
        Console.Write("Введите число - ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число - ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"НОД чисел - {NOD(x, y)}");
        Console.WriteLine("Задание 6 :");
        Console.Write("Введите строку - ");
        string s = Console.ReadLine();
        Console.WriteLine($"Строка является палиндромом - {Palindrop(s)}");

        
        



        // из урок7
        // 1
        Console.WriteLine("Задачи из 'Задачника'");
        int [] list = new int[5];

        // 2 
        string [] listStr = {"hi", "run", "good"};

        // 3
        int [] num = {33, 56, 77, 11, 0, 90};
        Console.WriteLine(num[1]);

        // 4
        num[2]=100;

        // 5
        Console.WriteLine(num.Length);

    }

    static bool Palindrop(string s)
    {
        string revers = new string(s.Reverse().ToArray());
        if (s == revers){return true;}
        else{return false;}
    }


    private static bool Pal(string s)
    {
        throw new NotImplementedException();
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

    static int NOD (int a, int b) {
    if (a == b) return a;
    else {
        if (a > b) {return NOD(a-b, b);}
        else {return NOD(a, b-a);}
    }

    
}
}

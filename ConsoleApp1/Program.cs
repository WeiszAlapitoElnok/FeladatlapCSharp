using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {

        static double TortNum()
        {
            double numb = 0;
            bool szam = false;
            do
            {
                try
                {
                    Console.Write("Írj be egy számot!: ");
                    numb = double.Parse(Console.ReadLine()!.Replace('.', ','));
                    szam = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ez nem szám!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"A számnak {double.MinValue} és {double.MaxValue} között kell lennie!");
                }
            }
            while (szam == false);

            return numb;
        }

        static int Num()
        {
            string be = "";
            int numb = 0;
            bool szam = false;

            do
            {
                try
                {
                    Console.Write("Írj be egy egész számot!: ");
                    be = Console.ReadLine()!.Replace('.', ',');
                    numb = int.Parse(be);
                    szam = true;
                }
                catch (FormatException)
                {
                    if (double.TryParse(be, out var ex))
                    {
                        Console.WriteLine("Egész számot adj meg!");

                    }
                    else
                    {
                        Console.WriteLine("Számot adj meg!");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"A számnak {int.MinValue} és {int.MaxValue} között kell lennie!");
                }
            }
            while (szam == false);

            return numb;
        }

        static int[] Array()
        {
            int size = Num();
            int[] num = new int[size];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Num();
            }
            return num;
        }

        static void F1()
        {
            Console.WriteLine("Hello world!");
        }

        static void F2()
        {
            Console.WriteLine("Hogy hívnak?");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Szia {name}!");
        }

        static void F3()
        {
            Console.WriteLine($"A szám kétszerese: {TortNum() * 2}");
        }

        static void F4()
        {
            double num1 = TortNum();
            double num2 = TortNum();
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            if (num1 != 0 && num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }

        }

        static void F5()
        {
            int num1 = Num();
            int num2 = Num();
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        static void F6()
        {
            List<int> list = new List<int>();
            list.Add(Num());
            list.Add(Num());
            list.Add(Num());
            int smalst = list[0];
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] < smalst)
                {
                    smalst = list[i];
                }
            }

            Console.WriteLine($"A legkisebb szám: {smalst}");
        }

        static void F7()
        {
            double num1 = TortNum();
            double num2 = TortNum();
            double num3 = TortNum();

            if (num1 + num2 < num3 || num2 + num3 < num1 || num1 + num3 < num3)
            {
                Console.WriteLine("Nem szerkeszthető!");
            }
            else
            {
                Console.WriteLine("Szerkeszthető!");
            }

        }

        static void F8()
        {
            int num1;
            int num2;
            do
            {
                Console.WriteLine("Kettő egész pozitív számot kérek");
                num1 = Num();
                num2 = Num();
            }
            while (num1! <= 0 || num2! <= 0);


            Console.WriteLine($"Számtani közép: {(num1 + num2) / 2}");
            Console.WriteLine($"Mértani közép: {Math.Sqrt(num1 * num2)}");
        }

        static void F9()
        {
            int a = Num();
            int b = Num();
            int c = Num();

            if ((b * b - 4 * a * c) >= 0)
            {
                Console.WriteLine("Van megoldása!");
            }
            else
            {
                Console.WriteLine("Nincs megoldása!");
            }
        }

        static void F10()
        {
            int a = Num();
            int b = Num();
            int c = Num();

            if ((b * b - 4 * a * c) >= 0)
            {
                Console.WriteLine($"A megoldás: {(-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)} és {(-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)}");
            }
            else
            {
                Console.WriteLine("Nincs megoldása!");
            }
        }

        static void F11()
        {
            double num1 = TortNum();
            double num2 = TortNum();

            Console.WriteLine($"Átfogó: {Math.Round(Math.Sqrt(num1 * num1 + num2 * num2), 2)}");
        }

        static void F12()
        {
            double num1 = TortNum();
            double num2 = TortNum();
            double num3 = TortNum();

            Console.WriteLine($"Térfogata: {num1 * num2 * num3}");
            Console.WriteLine($"Felszíne: {(num1 * num2 + num1 * num3 + num2 * num3) * 2}");
        }

        static void F13()
        {
            double num1 = TortNum();

            Console.WriteLine($"Kerülete: {num1 * Math.PI}");
            Console.WriteLine($"Területe: {((num1 / 2) * (num1 / 2)) * Math.PI}");
        }

        static void F14()
        {
            double r = TortNum();
            double alfa = TortNum();

            Console.WriteLine($"Körcik ív hossza: {2 * r * Math.PI * (alfa / 360)}");
            Console.WriteLine($"Körcik területe: {(r * r * alfa) / 2}");
        }

        static void F15()
        {
            int szam = Num();

            for (int i = 0; i <= szam; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void F16()
        {
            int szam = Num();

            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void F17()
        {
            int szam = Num();
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void F18()
        {
            int szam = Num();
            int oszt = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    oszt = oszt + i;
                }
            }
            Console.WriteLine(oszt);
        }

        static void F19()
        {
            int szam = Num();
            int oszt = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    oszt = oszt + i;
                }
            }
            if (oszt == szam * 2)
            {
                Console.WriteLine("tökéletes szám");
            }
            else
            {
                Console.WriteLine("nem tökéletes szám");
            }
        }

        static void F20()
        {
            int halap = Num();
            int kitevo = Num();
            // int szam = 1;

            /* for (int i = 0; i < kitevo; i++)
             {
                 szam = szam * halap;
             }
             Console.WriteLine(szam);*/

            Console.WriteLine(Math.Pow(halap, kitevo));
        }

        static void F21()
        {
            int num;
            do
            {
                num = Num();
            }
            while (num < 0);
        }

        static void F22()
        {
            int num;
            int osszeg = 0;
            do
            {
                num = Num();
                osszeg = osszeg + num;
            }
            while (num < 10);
            Console.WriteLine(osszeg);
        }

        static void F23()
        {
            int num = Num();
            do
            {
                Console.Write("2*");
                num = num / 2;
            }
            while (num%2 == 0);
            Console.Write(num);
        }

        static void F24()
        {
            string word = "";

            do
            {
                Console.WriteLine("Csak az alma szót fogadom el!");
                word = Console.ReadLine()!;
            }
            while (word != "alma");

            Console.WriteLine("Az alma gyümölcs!");
        }

        static void F25()
        {
            int num = Num();
            int i = 0;
            while (num >= 3)
            {
                num = num - 3;
                i++;
            }

            Console.WriteLine($"{i*3+num} = {i}*3+{num}");
        }

        static void F26()
        {
            int num = Num();
            int oszto = 1;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    oszto++;
                }
            }
            if (oszto == 2)
            {
                Console.WriteLine("prim");
            }
            else
            {
                Console.WriteLine("nem prim");
            }
        }

        static void F27()
        {
            int num = Num();
            int oszto = 1;

            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        oszto++;
                    }
                }
                if (oszto == 2)
                {
                    Console.WriteLine(i);
                }
                oszto = 1;
            }
        }

        static void F28()
        {
            int num = Num();
            int oszto = 1;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            oszto++;
                        }
                    }
                    if (oszto == 2)
                    {
                        Console.WriteLine(i);
                    }
                    oszto = 1;
                }
            }
        }

        static void F29()
        {
            int num = Num();
            int oszto = 1;

            while (num != 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                oszto++;
                            }
                        }
                        if (oszto == 2)
                        {
                            Console.WriteLine($"{num}|{i}");
                            num = num / i;
                            i = 1;
                        }
                        oszto = 1;
                    }
                }              
            }
            Console.WriteLine($"{1}|");
        }

        static void F30()
        {
            int num = Num();
            int num2 = Num();
            int smalst = 0;

            if (num < num2)
            {
                for (int i = num; i > 0; i--)
                {
                    if (num % i == 0 && num2 % i == 0)
                    {
                        if (smalst < i)
                        {
                            smalst = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = num2; i > 0; i--)
                {
                    if (num % i == 0 && num2 % i == 0)
                    {
                        if (smalst < i)
                        {
                            smalst = i;
                        }
                    }
                }
            }
            Console.WriteLine(smalst);
        }

        static void F31()
        {
            int num = Num();
            int num2 = Num();
            int smalst = num*num2;

            for (int i = 1; i < (num*num2); i++)
            {
                if (i % num == 0 && i % num2 == 0)
                {
                    if (i < smalst)
                    {
                        smalst = i;
                    }
                }
            }
            Console.WriteLine(smalst);
        }

        static void F32()
        {
            int num = Num();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
            }
        }

        static void F33()
        {
            int num = Num();
            for (int i = 1; i <= num; i++)
            {

                for (int j = 1; j <= num; j++)
                {
                    Console.WriteLine($"{i}+{j}={i + j}");
                }
            }

        }

        static void F34()
        {
            int inv = 0;
            int inv2 = 0;
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {
                    inv = i/10+(i%10) * 10;
                    inv2 = j / 10 + (j % 10) * 10;
                    if (j*i == inv * inv2)
                    {
                        Console.WriteLine($"{i},{j}");
                    }
                }
            }
        }

        static void F35()
        {
            int start = 97;
            do
            {
                
                for (int i = start; i < start + 4; i++)
                {

                    if (i < 122)
                    {
                        Console.Write($"{Convert.ToChar(i)} {i}\t");
                    }
                   
                }
                Console.WriteLine();
                start = start + 4;

            } while (start < 122);



        }

        static void F36()
        {
            int x = Num();
            int y = Num();
            bool sym = false;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i % 2 == 0 && j == 0)
                    {
                        sym = true;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            sym = false;
                        }
                        
                    }

                    if (sym)
                    {
                        Console.Write("X");
                        sym = false;
                    }
                    else
                    {
                        Console.Write("O");
                        sym = true;
                    }
                }
                Console.WriteLine();
            }
        }

        static void F37()
        {
            int a = Num();
            int sor = 1;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                sor = sor + 2;
            }
        }

        static void F38()
        {
            int a = Num();
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void F39()
        {
            int a = Num();
            int b = Num();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0 || i == a-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == b - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        static void F40()
        {
            int sum = 0;
            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
            }
        }

        static void F41()
        {
            int start = 65;
            for (int i = 0; i < 26; i++)
            {
                for (int j = start; j < 91; j++)
                {
                    Console.Write($"{Convert.ToChar(j)}");
                }
                for (int j = 65; j < start; j++)
                {
                    Console.Write($"{Convert.ToChar(j)}");
                }
                Console.WriteLine();
                start++;
            }
        }

        static void F42()
        {
            int[] nums = Array();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }

        static void F43()
        {
            int[] nums = Array();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum = sum + nums[i];
                }
            }
            Console.WriteLine(sum);
        }

        static void F44()
        {
            int[] nums = Array();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine($"{nums[i]} a(z) {i}. helyen van");
                }
            }
        }

        static void F45()
        {
            int[] nums = Array();
            int num = Num();
            bool van = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    Console.WriteLine($"A {num} a(z) {i}. helyen van!");
                    van = true;
                    break;
                }
            }
            if (van == false)
            {
                Console.WriteLine("A tömben nincs ilyen szám!");
            }

        }

        static void F46()
        {
            int[] nums = Array();
            int num = Num();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    sum++;
                }
            }
            
            Console.WriteLine($"A {num} {sum}-szor szerepel a tömben!");
            
        }

        static void F47()
        {
            int size = Num();
            int num = 0;
            string[] names = new string[size];
            Console.WriteLine("Add meg a keresett tanuló keresztnevét nevét:");
            string kname = Console.ReadLine()!;
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Adj meg egy keresztnevet!");
                names[i] = Console.ReadLine()!;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == kname)
                {
                    num++;
                }
            }
            Console.WriteLine($"{num} {kname} keresztnevű tanuló jár az osztályba");

        }

        static void F48()
        {
            int[] nums = Array();
            Console.WriteLine(nums.Max()-nums.Min());
        }

        static void F49()
        {
            int[] nums = Array();
            int num = 0;
            for (int i = nums.Length; i > 1; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        num = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = num;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
            static void Main(string[] args)
        {
           
        }
    }
}

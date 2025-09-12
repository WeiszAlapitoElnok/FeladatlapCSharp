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
                    Console.Write("adj egy számot: ");
                    numb = double.Parse(Console.ReadLine()!);
                    szam = true;
                }
                catch (FormatException)
                {
                    Console.Write("ez nem szám! ");
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
                    Console.Write("adj egy egész számot: ");
                    be = Console.ReadLine()!.Replace('.', ',');
                    numb = int.Parse(be);
                    szam = true;
                }
                catch (FormatException)
                {
                    if (double.TryParse(be, out var ex))
                    {
                        Console.WriteLine("egész számot adj meg");
                        
                    }
                    else
                    {
                        Console.WriteLine("számot adj meg");
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

        static void F1()
        {
            Console.WriteLine("Hello world!");
        }

        static void F2()
        {
            Console.WriteLine("hogy hívnak?");
            string name = Console.ReadLine()!;
            Console.WriteLine($"szia {name}");
        }

        static void F3()
        {
            Console.WriteLine(TortNum()*2);
        }

        static void F4()
        {
            double szam1 = TortNum();
            double szam2 = TortNum();
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam1 - szam2);
            Console.WriteLine(szam1 * szam2);
            if (szam1!=0 && szam2 !=0)
            {
                Console.WriteLine(szam1 / szam2);
            }

        }

        static void F5()
        {
            int szam1 = Num();
            int szam2 = Num();
            if (szam1 > szam2)
            {
                Console.WriteLine(szam1);
            }
            else
            {
                Console.WriteLine(szam2);
            }
        }

        static void F6()
        {
            List<int> list = new List<int>();
            list.Add(Num());
            list.Add(Num());
            list.Add(Num());
            int legkis = list[0];
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i]<legkis)
                {
                    legkis = list[i];
                }
            }

            Console.WriteLine(legkis);
        }

        static void F7()
        {
            double szam1 = TortNum();
            double szam2 = TortNum();
            double szam3 = TortNum();

            if (szam1 + szam2 < szam3 || szam2 + szam3 < szam1 || szam1 + szam3 < szam3)
            {
                Console.WriteLine("nem szerkesztheő");
            }
            else
            {
                Console.WriteLine("szerkeszthető");
            }

        }

        static void F8()
        {
            int szam1;
            int szam2;
            do
            {
                Console.WriteLine("kettő egész pozitív számot kérek");
                szam1 = Num();
                szam2 = Num();
            }
            while (szam1 !<= 0 || szam2 !<= 0);


            Console.WriteLine($"számtani közép {(szam1+szam2)/2}");
            Console.WriteLine($"mértani közép{Math.Sqrt(szam1*szam2)}");
        }

        static void F9()
        {
            int a = Num();
            int b = Num();
            int c = Num();

            if ((b*b-4*a*c)>=0)
            {
                Console.WriteLine("van megoldása");
            }
            else
            {
                Console.WriteLine("nincs megoldása");
            }
        }

        static void F10()
        {
            int a = Num();
            int b = Num();
            int c = Num();

            if ((b * b - 4 * a * c) >= 0)
            {
                Console.WriteLine($"a megoldás: {(-b + Math.Sqrt(b * b - 4 * a * c))/(2*a)} és {(-b - Math.Sqrt(b * b - 4 * a * c))/(2*a)}");
            }
            else
            {
                Console.WriteLine("nincs megoldása");
            }
        }

        static void F11()
        {
            double szam1 = TortNum();
            double szam2 = TortNum();

            Console.WriteLine($"átfogó: {Math.Round(Math.Sqrt(szam1*szam1+szam2*szam2),2)}");
        }

        static void F12()
        {
            double szam1 = TortNum();
            double szam2 = TortNum();
            double szam3 = TortNum();

            Console.WriteLine($"térfogata: {szam1*szam2*szam3}");
            Console.WriteLine($"felszíne: {(szam1*szam2+szam1*szam3+szam2*szam3)*2}");
        }

        static void F13()
        {
            double szam1 = TortNum();

            Console.WriteLine($"kerülete: {szam1*Math.PI}");
            Console.WriteLine($"területe: {((szam1/2)*(szam1/2)) * Math.PI}");
        }

        static void F14()
        {
            double r = TortNum();
            double alfa = TortNum();

            Console.WriteLine($"körcik ív hossza: {2 * r * Math.PI * (alfa / 360)}");
            Console.WriteLine($"körcik területe: {(r*r*alfa)/2}");
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
                if (szam%i==0)
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
            int szam = 1;

            for (int i = 0; i < kitevo; i++)
            {
                szam = szam * halap;
            }
            Console.WriteLine(szam);

            Console.WriteLine(Math.Pow(halap,kitevo));
        }

            static void Main(string[] args)
        {
           
        }
    }
}

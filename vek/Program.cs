using System;

namespace vek
{
    class Program
    {
        static void Main(string[] args)
        {
            double vek;
            double RokNarozeni;
            double AktualniRok;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("vypočet věku");
                Console.Write("kdy ses narodil: ");
                double.TryParse(Console.ReadLine(), out RokNarozeni);

                AktualniRok = DateTime.Now.Year;
                vek = AktualniRok - RokNarozeni;
                Console.WriteLine($"tvuj věk je {vek}");
                if (vek > 80)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi stařešina");
                }
                if (vek <= 80 & vek > 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi postarší");
                }
                if (vek <= 60 & vek > 40)
                {
                    Console.WriteLine();
                    Console.WriteLine("nejsi nejmladší");
                }
                if (vek <= 40 & vek > 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi v nejlepším věku");
                }
                if (vek <= 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi mlaďoch :D");
                }
                        Console.ReadLine();
            }
           
            
            


        }
    }
}

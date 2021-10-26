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

                Console.ReadLine();
            }
           
            
            


        }
    }
}

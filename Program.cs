using System;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCalculation = true;
            while (newCalculation)
            {
                Console.WriteLine("Wprowadź cyfry i znaki oddzielone spacją: ");
                try
                {
                    string equation = Console.ReadLine();
                    ONPLogic onpLogic = new ONPLogic(equation);
                    Console.WriteLine(onpLogic.Calculator());

                }
                catch (Exception)
                {
                    Console.WriteLine("Tylko liczby i + - * / ^ te znaki.");
                }
                Console.WriteLine("Chcesz wprowadzić nowe obliczenie?(y/n)");
                if (Console.ReadLine() != "y")
                    newCalculation = false;
            }
            Console.ReadKey();
        }  
    }

}
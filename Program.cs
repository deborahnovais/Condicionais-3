using System;

namespace Condicionais_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, meses, dias, horas, minutos;
            Console.WriteLine("Quantos anos você tem?");
            idade = int.Parse(Console.ReadLine());
            meses = idade * 12;
            dias = idade * 365;
            horas = dias * 24;
            minutos = horas * 60;

            Console.WriteLine("A sua idade em meses é: {0}", meses);
            Console.WriteLine("A sua idade em dias é: {0}", dias);
            Console.WriteLine("A sua idade em horas é: {0}", horas);
            Console.WriteLine("A sua idade em minutos é: {0}", minutos);
        }
    }
}

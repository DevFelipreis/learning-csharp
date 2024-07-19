using System;
using System.Globalization;

namespace ClassOne
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            Console.WriteLine(x);

            char feminino = 'f';
            Console.WriteLine(feminino);

            string name = "Felipe";
            Console.WriteLine(name);
            Console.Write(name);

            bool status = true;
            Console.WriteLine(status);

            double number = 3.149000;
            Console.WriteLine(number.ToString("F2"));
            Console.WriteLine(number.ToString("F4", CultureInfo.InvariantCulture));

            int idade = 32;
            string nome = "Felipe";
            double salario = 5000.999;

            Console.WriteLine("Nome: {0} Idade: {1} Salario: {2}", nome, idade, salario);

            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos. Recebo {salario:f2} por mês.");

        }
    }
}


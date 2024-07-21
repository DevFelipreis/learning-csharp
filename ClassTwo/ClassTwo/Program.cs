namespace ClassTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = 8;
            b = 4;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("________________________________________");

            int c = 8;
            int d = 3;
            double result = (double)c / d;
            Console.WriteLine(result);
            Console.WriteLine("________________________________________");

            int soma = 8 + 3;
            int multiplicacao = 8 * 3;
            double divisao = (double)8 / 3;
            int subtracao = 8 - 3;
            int resto = 8 % 6;
            decimal operacao = 8 + 3 * 2 * (multiplicacao + (decimal)divisao - (subtracao - (decimal)resto));

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Resto: {resto}");
            Console.WriteLine($"Operação: {operacao.ToString("f2")}");
            Console.WriteLine("________________________________________");

            a = 40;
            b = 20;
            c = 2;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if (delta >= 0)
            {
                double baskara1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double baskara2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("____________________Báskara____________________");
                Console.WriteLine($"Delta: {delta}");
                Console.WriteLine($"Raiz 1: {baskara1.ToString("F2")}");
                Console.WriteLine($"Raiz 2: {baskara2.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("____________________Báskara____________________");
                Console.WriteLine("A equação não possui raízes reais.");
            }

        }
    }
}



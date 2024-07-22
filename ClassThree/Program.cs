using System;
using System.Globalization;

namespace ClassThree
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string cor1 = Console.ReadLine();
            string cor2 = Console.ReadLine();
            string cor3 = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine($"Você digitou a frase: {frase}");
            Console.WriteLine($"Você digitou as cores: {cor1}, {cor2} e {cor3}");

            Console.WriteLine($"As cores em ordem de leitura é: {vet[0]}, {vet[1]} e {vet[2]}");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu sexo(F para feminino e M para masculino):");
            char sexo = char.Parse(Console.ReadLine());

            if (idade > 1 && sexo == 'M' || sexo == 'm')
            {
                Console.WriteLine($"Olá {nome}, Sua idade é {idade} anos, sua altura é {altura}m e você é do sexo é masculino");
            }
            else if (idade < 1 && sexo == 'M' || sexo == 'm')
            {
                Console.WriteLine($"Olá {nome}, Sua idade é {idade} ano, sua altura é {altura}m e você é do sexo é masculino");
            }
            else if (idade > 1 && sexo == 'F' || sexo == 'f')
            {
                Console.WriteLine($"Olá {nome}, Sua idade é {idade} anos, sua altura é {altura}m e você é do sexo é feminino");
            }
            else
            {
                Console.WriteLine($"Olá {nome}, Sua idade é {idade} ano, sua altura é {altura}m e seu sexo é {sexo}");
            }


            Console.WriteLine("Digite seu nome completo:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu último nome, idade e altura(mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');
            string sobrenome = vetor[0];
            int idade2 = int.Parse(vetor[1]);
            double altura2 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("____________________");
            Console.WriteLine(nome2);
            Console.WriteLine("____________________");
            Console.WriteLine(quartos);
            Console.WriteLine("____________________");
            Console.WriteLine(preco);
            Console.WriteLine("____________________");
            Console.WriteLine(sobrenome);
            Console.WriteLine("____________________");
            Console.WriteLine(idade2);
            Console.WriteLine("____________________");
            Console.WriteLine(altura2);
            Console.WriteLine("____________________");

        }

    }
}


using System;

namespace AulaPOOCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Escolha a operação que quer realizar:");
            inicio:
            Console.WriteLine("1. Soma;\n2. Subtração;\n3. Multiplicação;\n4. Divisão;\n5. Média Aritmética.");
            int op = int.Parse(Console.ReadLine());
            while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5) {
                Console.WriteLine("Escolha uma operação válida!\n");
                goto inicio;
            }

            if (op == 1) {
                Fundamentais fundsoma = new Fundamentais();
                Console.WriteLine("Escolha o primeiro número:");
                fundsoma.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo número:");
                fundsoma.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nResultado:");
                Console.WriteLine(fundsoma.Somar (fundsoma.num1, fundsoma.num2));
            }

            if (op == 2) {
                Fundamentais fundsub = new Fundamentais();
                Console.WriteLine("Escolha o primeiro número:");
                fundsub.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo número:");
                fundsub.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nResultado:");
                Console.WriteLine(fundsub.Subtrair (fundsub.num1, fundsub.num2));
            }

            if (op == 3) {
                Fundamentais fundmult = new Fundamentais();
                Console.WriteLine("Escolha o primeiro número:");
                fundmult.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo número:");
                fundmult.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nResultado:");
                Console.WriteLine(fundmult.Multiplicar (fundmult.num1, fundmult.num2));
            }

            if (op == 4) {
                Fundamentais funddiv = new Fundamentais();
                Console.WriteLine("Escolha o primeiro número:");
                funddiv.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo número:");
                funddiv.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nResultado:");
                Console.WriteLine(funddiv.Dividir (funddiv.num1, funddiv.num2));
            }

            if (op == 5) {
                Adicionais admed = new Adicionais();
                Console.WriteLine("Escolha o primeiro número:");
                admed.num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo número:");
                admed.num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o terceiro número:");
                admed.num3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o quarto número:");
                admed.num4 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nResultado:");
                Console.WriteLine(admed.CalcularMedia (admed.num1, admed.num2, admed.num3, admed.num4));
            }
        }
    }
}

using System;
using System.Globalization;

namespace CalculoDasAreas

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Triangulo, Circulo,
                   Trapezio, Quadrado, Retangulo, pi = 3.14159;

            Console.WriteLine("Calculo das Áreas do Tringulo, Circulo, Trâpezio, Quadrado e Retângulo. ");
            Console.WriteLine();

            Console.Write("Digite o valor da BASE: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do LADO: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da ALTURA: ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Triangulo = (A * C) / 2;
            Circulo = pi * (C * C);
            Trapezio = (A + B) * C / 2;
            Quadrado = (B * B);
            Retangulo = (B * A);

            Console.WriteLine("Triângulo: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }

    }
}
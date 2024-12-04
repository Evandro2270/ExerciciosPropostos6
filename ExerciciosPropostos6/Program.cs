using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;
    using System.Data;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
                string[] vet = Console.ReadLine().Split(' ');
                a = double.Parse(vet[0], CI);
                b = double.Parse(vet[1], CI);
                c = double.Parse(vet[2], CI);

                triangulo = a * c / 2.0;
                circulo = 3.14159 * c * c;
                trapezio = (a + b) / 2.0 * c;
                quadrado = b * b;
                retangulo = a * b;

                Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CI));
                Console.WriteLine("Circulo: " + circulo.ToString("F3", CI));
                Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CI));
                Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CI));
                Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CI));

            }
        }
    }
}
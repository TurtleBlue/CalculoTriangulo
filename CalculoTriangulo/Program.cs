using System.Runtime.CompilerServices;

namespace CalculoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();    

            Console.WriteLine("Insira as medidas do triângulo X:");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nAgora insira as medidas do triângulo Y:");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.Clear();
            Console.WriteLine($"A área do triangulo X é {areaX:n4} e a área do triangulo Y é {areaY:n4}");

            if (areaX > areaY)
            {
                Console.WriteLine("A área do triangulo X é a maior");
            } 
            else
            {
                Console.WriteLine("A área do triangulo Y é a maior");
            }
        }
    }
}
using System;

namespace formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---BHASKARA - CALCULADORA---");

            double a, b, c, delta, r1, r2;
            string resp;

            do
            {
                Console.Write("\nInforme os números da equação (Ax² + Bx + C), separados pela tecla 'espaço': ");
                string[] valor = Console.ReadLine().Split(' ');

                a = Convert.ToDouble(valor[0]);
                b = Convert.ToDouble(valor[1]);
                c = Convert.ToDouble(valor[2]);

                delta = (Math.Pow(b, 2) - (4 * a * c));
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                if (a == 0 || delta < 0)
                {
                    Console.WriteLine("Impossível calcular");
                }
                else
                {
                    Console.WriteLine($"R1 = {r1:0.00000}");
                    Console.WriteLine($"R2 = {r2:0.00000}");
                }

                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
            
        }
    }
}

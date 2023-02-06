using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompletaDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nuevo11
            int opcion = 0;
            Console.WriteLine("Calculadora");
            Console.WriteLine("opciones:");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Cancelar");
            Console.WriteLine("Digite una opcion");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    lasuma();
                    break;
                case 2:
                    laresta();
                    break;
                case 3:
                    lamulti();
                    break;
                case 4:
                    ladivi();
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
            //nuevo12
           
        }
        private static void lasuma()
        {
            Console.Clear();
            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;
            Console.WriteLine("Operacion: Suma");
            Console.WriteLine("Digite su primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.Clear() ;
            Console.WriteLine("Su resultado es: " + resultado);
            Console.ReadLine();
            Environment.Exit(0);

        }
        private static void laresta()
        {
            Console.Clear();
            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;
            Console.WriteLine("Operacion: Resta");
            Console.WriteLine("Digite su primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.Clear();
            Console.WriteLine("Su resultado es: " + resultado);
            Console.ReadLine();
            Environment.Exit(0);
        }
        private static void lamulti()
        {
            Console.Clear();
            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;
            Console.WriteLine("Operacion: Multiplicacion");
            Console.WriteLine("Digite su primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.Clear();
            Console.WriteLine("Su resultado es: " + resultado);
            Console.ReadLine();
            Environment.Exit(0);
        }
        private static void ladivi()
        {
            Console.Clear();
            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;
            Console.WriteLine("Operacion: Division");
            Console.WriteLine("Digite su primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.Clear();
            Console.WriteLine("Su resultado es: " + resultado);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}

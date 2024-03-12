using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: "+ resultado);
            double imc = double.Parse(Console.ReadLine());
            
            if( imc < 16.9);
            {
                Console.WriteLine("Muito abaixo do peso!");
            }
            if (imc < 17);
            {
                Console.WriteLine("Abaixo do peso!");
            }
            if (imc < 18.4);
            {
                Console.WriteLine("Abaixo do peso!");
            }

            if (imc > 18.5);
            {
                Console.WriteLine("Peso normal!");
            }

            if (imc > 24.9);
            {
                Console.WriteLine("Peso normal!");
            }

            if (imc > 16.9);
            {
                Console.WriteLine("Muito abaixo do peso!");
            }
            if (imc > 16.9);
            {
                Console.WriteLine("Muito abaixo do peso!");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console {
    class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("Calculadora simples: divisão"); 
            Console.WriteLine("****************************"); 
            Console.Write("Insira o numerador:"); 
            int numerador = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Insira o denominador:"); 
            int denominador = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("numerador/denominador = {0}/{1} = {2}", numerador, denominador, numerador / denominador);
            */
            //ex1 ponto 8
            try { 
                Console.WriteLine("Calculadora simples: divisão"); 
                Console.WriteLine("****************************"); 
                Console.Write("Insira o numerador:"); 
                int numerador = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Insira o denominador:"); 
                int denominador = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("numerador/denominador = {0}/{1} = {2}", numerador, denominador, numerador / denominador); 
            }
            catch (FormatException) { 
                Console.WriteLine("Deve inserir um número válido."); 
            }
            catch(DivideByZeroException) {
                Console.WriteLine("Divisão por zero. Escolha outro denominador.");
            }
        }

    }
}
